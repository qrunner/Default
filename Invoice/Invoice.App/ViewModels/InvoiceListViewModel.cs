using System;
using System.Data.Entity;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using Invoice.App.ViewModels.Filters;
using Sirius.Desktop;

namespace Invoice.App.ViewModels
{
    public class InvoiceListViewModel : ViewModel, IDisposable
    {
        public InvoiceListViewModel()
        {
            RegisterCommand(new ActionCommand("Add",
                (x) => InvoiceApp.RouteManager.RedirectToRoute(Route.EditInvoice),
                (x) => true, "Создать", CategoryOperations));

            RegisterCommand(new ActionCommand("Edit",
                (x) => InvoiceApp.RouteManager.RedirectToRoute(Route.EditInvoice, new { id = Current.Id }),
                (x) => Current != null, "Редактировать", CategoryOperations));

            RegisterCommand(new ActionCommand("Delete",
                (x) => DataContext.Invoices.Remove(Current),
                (x) => Current != null, "Удалить", CategoryOperations));

            RegisterCommand(new ActionCommand("PrintPreview",
                (x) => InvoiceApp.RouteManager.RedirectToRoute(Route.PrintPreview, new { id = Current.Id }),
                (x) => Current != null, "Просмотр печати", "Печать"));

           /* RegisterCommand(new ActionCommand("Print",
                (x) =>
                {
                    var prnModel = new InvoicePrintPreviewModel();
                    prnModel.Initialize(new { id = Current.Id });
                    prnModel.Print();
                },
                (x) => Current != null, "Быстрая печать", "Печать"));*/

            RegisterCommand(new ActionCommand("Save", (x) => Save(), (x) => DataContext.IsChanged, "Сохранить", CategoryOperations, 10));

            var filters = new FilterViewModel[] { new Tomorrow(), new Today(), new Yesterday(), new ThisWeek(), new PrevWeek(), new ThisMonth(), new ThisYear() };

            foreach (var filterItem in filters)
            {
                RegisterCommand(new ActionCommand(filterItem.GetType().FullName,
                (x) => InvoiceApp.RouteManager.RedirectToRoute(Route.InvoiceList, new { filter = filterItem }),
                (x) => CurrentFilter == null ? true : CurrentFilter.Name != filterItem.Name, filterItem.Name, CategoryFilter));
            }

            InvoiceApp.CurrentSupplierChanged += InvoiceApp_CurrentSupplierChanged;
        }

        void InvoiceApp_CurrentSupplierChanged(object sender, EventArgs e)
        {
            Refresh(new { filter = CurrentFilter });
        }

        public override void Initialize(object parameter)
        {
            base.Initialize(parameter);

            Refresh(parameter);
        }

        private void Refresh(object parameter)
        {
            UpdateDataContext();

            DataContext.Producers.Load();
            DataContext.Suppliers.Load();
            DataContext.Customers.Load();
            DataContext.Packings.Load();
            DataContext.Products.Load();
            DataContext.MeasureUnits.Load();
            // DataContext.Invoices.Load();

            Expression<Func<Model.Invoice, bool>> filter2 = x => x.Supplier.Id == InvoiceApp.CurrentSupplier.Id;
            var filter = (FilterViewModel)ParseParam(parameter, "filter");
            CurrentFilter = filter;
            IQueryable<Model.Invoice> query = DataContext.Invoices;
            query = query.Where(filter.FilterExpression);
            query = query.Where(filter2);
            query.Load();
            Invoices = DataContext.Invoices.Local.ToBindingList();

            RaiseRefreshed();
        }

        public Model.Invoice Current { get; set; }

        public BindingList<Model.Invoice> Invoices { get; set; }

        public FilterViewModel CurrentFilter { get; private set; }

        public void Dispose()
        {
            InvoiceApp.CurrentSupplierChanged -= InvoiceApp_CurrentSupplierChanged;
        }

        public event EventHandler Refreshed;

        public void RaiseRefreshed()
        {
            var evh = Refreshed;
            if (evh != null)
                Refreshed(this, EventArgs.Empty);
        }
    }
}