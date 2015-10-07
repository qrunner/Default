using System;
using Invoice.App.ViewModels;
using Sirius.Desktop;

namespace Invoice.App.Views
{
    public partial class InvoiceListView : GridEditor
    {
        public InvoiceListView()
        {
            InitializeComponent();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView GridView
        {
            get { return gridView1; }
        }

        public override void SetModel(IViewModel model)
        {
            var rowHandle = gridView1.FocusedRowHandle;
            gridView1.DataController.AllowIEnumerableDetails = true;
            base.SetModel(model);
            /*if (InvoiceApp.SelectedInvoices != null && InvoiceApp.SelectedInvoices.Length > 0)
            {
                var sel = (model as IEnumerable<Model.Invoice>).Where(x => x.Id == InvoiceApp.SelectedInvoices[0]).ToArray();
                var index = bindingSource.IndexOf(sel);
                bindingSource.Position = index;
            }*/
            gridView1.FocusedRowHandle = rowHandle;
            (model as InvoiceListViewModel).Refreshed -= InvoiceListView_Refreshed;
            (model as InvoiceListViewModel).Refreshed += InvoiceListView_Refreshed;
        }

        void InvoiceListView_Refreshed(object sender, EventArgs e)
        {
            base.SetModel(sender as IViewModel);
        }
        

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            InvoiceApp.SelectedInvoices = new[] { (gridView1.GetFocusedRow() as Model.Invoice).Id };             
        } 
    }
}