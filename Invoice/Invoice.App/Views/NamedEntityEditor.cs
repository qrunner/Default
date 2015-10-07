namespace Invoice.App.Views
{
    public partial class NamedEntityEditor : GridEditor
    {
        public NamedEntityEditor()
        {
            InitializeComponent();
            bindingSource.DataSource = typeof(Invoice.App.Views.INamedEntityList);
            bindingSource.DataMember = "Items";            
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView GridView
        {
            get { return gridView2; }
        }   
    }
}