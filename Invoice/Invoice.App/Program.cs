using Invoice.App.ViewModels;
using Invoice.App.Views;
using Invoice.Model;
using System;
using System.Windows.Forms;
using Sirius.Desktop;

namespace Invoice.App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainForm = new frmMain();

            InvoiceApp.RegisterMainForm(mainForm);

            InvoiceApp.RouteManager.RegisterRoute(Route.InvoiceList, new RouteItem<InvoiceListViewModel, InvoiceListViewTest>(mainForm, mainForm, false));
            InvoiceApp.RouteManager.RegisterRoute(Route.EditInvoice, new RouteItem<InvoiceViewModel, InvoiceEditor>(mainForm, mainForm, false));
            InvoiceApp.RouteManager.RegisterRoute(Route.RefMeasureUnits, new RouteItem<MeasureUnitsViewModel, MeasureUnitsEditor>(mainForm, mainForm));
            InvoiceApp.RouteManager.RegisterRoute(Route.PrintPreview, new RouteItem<InvoicePrintPreviewModel, PrintPreviewViewTest>(mainForm, mainForm, false));
            InvoiceApp.RouteManager.RegisterRoute(Route.RefProducts, new RouteItem<ProductViewModel, ProductEditor>(mainForm, mainForm));
            InvoiceApp.RouteManager.RegisterRoute(Route.RefPacking, new RouteItem<PackingViewModel, PackingEditor>(mainForm, mainForm));
            InvoiceApp.RouteManager.RegisterRoute(Route.RefCustomers, new RouteItem<NamedEntityViewModel<Customer>, NamedEntityEditor>(mainForm, mainForm));
            InvoiceApp.RouteManager.RegisterRoute(Route.RefProducers, new RouteItem<NamedEntityViewModel<Producer>, NamedEntityEditor>(mainForm, mainForm));
            InvoiceApp.RouteManager.RegisterRoute(Route.RefSuppliers, new RouteItem<NamedEntityViewModel<Supplier>, NamedEntityEditor>(mainForm, mainForm));

            Application.Run(mainForm);
        }
    }
}