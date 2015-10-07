namespace Invoice.App.Views
{
    public partial class MeasureUnitsEditor : GridEditor
    {
        public MeasureUnitsEditor()
        {
            InitializeComponent();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView GridView
        {
            get { return gridView1; }
        }
    }
}