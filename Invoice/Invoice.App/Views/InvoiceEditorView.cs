using DevExpress.XtraEditors;
using Sirius.Desktop;

namespace Invoice.App.Views
{
    public partial class InvoiceEditorView : XtraUserControl, IView
    {
        public InvoiceEditorView()
        {
            InitializeComponent();
        }

        public void SetModel(IViewModel model)
        {
            invoiceViewModelBindingSource.DataSource = model;
        }
    }
}
