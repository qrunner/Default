using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.ComponentModel;
using Invoice.App.Print;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting.Preview;
using Sirius.Desktop;

namespace Invoice.App.ViewModels
{
    public class InvoicePrintPreviewModel : ViewModel, IPrintPreviewViewModel
    {
        public InvoicePrintPreviewModel()
        {
            RegisterCommand(new ActionCommand("Print", (x) => Print(), (x) => DocumentSource != null, "Печать"));
        }

        public override void Initialize(object parameter)
        {
            base.Initialize(parameter);

            var id = (int)ParseParam(parameter, "id");

            DataContext.Producers.Load();
            DataContext.Suppliers.Load();
            DataContext.Customers.Load();
            DataContext.Packings.Load();
            DataContext.Products.Load();
            DataContext.MeasureUnits.Load();

            var invoices = DataContext.Invoices;
            invoices.Where(x => x.Id == id).Load();
            Invoices = DataContext.Invoices.Local.ToBindingList();

            var report = new xrInvoice();
            report.DataSource = invoices.Where(x => x.Id == id).ToArray();
            report.CreateDocument(true);            
            DocumentSource = report;
        }

        public BindingList<Model.Invoice> Invoices { get; set; }

        public object DocumentSource { get; protected set; }

        public void Print()
        {
            using (ReportPrintTool printTool = new ReportPrintTool(DocumentSource as XtraReport))
            {                
                printTool.Print();             
            }            
        }
    }
}