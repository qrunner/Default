using System;
using System.Linq;
using System.Data.Entity;
using System.ComponentModel;
using Invoice.Model;
using Sirius.Desktop;

namespace Invoice.App.ViewModels
{
    class InvoiceViewModel : ViewModel
    {
        public InvoiceViewModel()
        {
            RegisterCommand(new ActionCommand("Save", x => Save(), x => DataContext.IsChanged, "Сохранить", CategoryOperations));

            RegisterCommand(new ActionCommand("Print",
             x => InvoiceApp.RouteManager.RedirectToRoute(Route.PrintPreview, new { id = Invoice.Id }),
             x => Invoice.Id > 0, "Просмотр печати", "Печать"));            
        }

        public Model.Invoice Invoice { get; set; }

        public override void Initialize(object parameter)
        {
            base.Initialize(parameter);

            DataContext.Producers.Load();
            DataContext.Suppliers.Load();
            DataContext.Customers.Load();
            DataContext.Packings.Load();
            DataContext.Products.Load();
            DataContext.MeasureUnits.Load();

            if (parameter != null)
            {
                var id = (int)ParseParam(parameter, "id");
                DataContext.Invoices.Where(x => x.Id == id).Load();
                Invoice = DataContext.Invoices.Local.Single(x => x.Id == id);
            }
            else
                Invoice = DataContext.Invoices.Add(new Model.Invoice
                {
                    Date = Properties.Settings.Default.DefaultTomorrow ? DateTime.Today.AddDays(1) : DateTime.Today,
                    Producer = DataContext.Producers.SingleOrDefault(x => x.Id == Properties.Settings.Default.LastProducer),
                    Supplier = DataContext.Suppliers.Single(x=>x.Id == InvoiceApp.CurrentSupplier.Id)
                });
            
            Producers = DataContext.Producers.Local.ToBindingList();
            Suppliers = DataContext.Suppliers.Local.ToBindingList();
            Customers = DataContext.Customers.Local.ToBindingList();
            Packings = DataContext.Packings.Local.ToBindingList();
            Products = DataContext.Products.Local.ToBindingList();
        }

        public BindingList<Producer> Producers { get; set; }

        public BindingList<Supplier> Suppliers { get; set; }

        public BindingList<Customer> Customers { get; set; }

        public BindingList<Packing> Packings { get; set; }

        public BindingList<Product> Products { get; set; }
    }
}