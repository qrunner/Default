using Invoice.App.ViewModels;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using Sirius.Desktop;
using Sirius.Desktop.DevExpress;

namespace Invoice.App.Views
{
    public partial class InvoiceEditor : ViewBase
    {
        public InvoiceEditor()
        {
            InitializeComponent();

            Application.Idle += Application_Idle;
        }

        void Application_Idle(object sender, EventArgs e)
        {
            /*cbPacking.Enabled =
                cbProduct.Enabled =
                tbCount.Enabled =
                itemsBindingSource.Current != null;

            deDate.Enabled =
                cbCustomer.Enabled =
                cbProducer.Enabled =
                cbSupplier.Enabled =
                tbReason.Enabled =
                invoicesBindingSource.Current != null;*/
        }

        public override void SetModel(IViewModel model)
        {
            base.SetModel(model);
            bsInvoice.DataSource = (model as InvoiceViewModel).Invoice;
            //invoicesBindingSource.Position = invoicesBindingSource.IndexOf((model as InvoiceListViewModel).Current);
        }

        public EventHandler InvoiceAddRequested;

        public EventHandler InvoiceItemAddRequested;

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            bsInvoice.EndEdit();
            itemsBindingSource.EndEdit();

            bsInvoice.AddNew();
            itemsBindingSource.AddNew();
        }

        private void AddItemClick(object sender, EventArgs e)
        {
            bsInvoice.EndEdit();
            itemsBindingSource.EndEdit();
            
            itemsBindingSource.AddNew();
            PointerToControl(cbProduct);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            bsInvoice.EndEdit();
            itemsBindingSource.EndEdit();            
        }

        private void tbCount_Enter(object sender, EventArgs e)
        {
            tbCount.SelectAll();
        }

        private void cbProduct_Properties_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            if (e.CloseMode == DevExpress.XtraEditors.PopupCloseMode.Normal)
                PointerToControl(cbPacking);
        }

        private void cbPacking_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            PointerToControl(tbCount);
        }

        private void tbCount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddItemClick(this, EventArgs.Empty);
        }

        private void cbCustomer_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void cbCustomer_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            
        }
    }
}