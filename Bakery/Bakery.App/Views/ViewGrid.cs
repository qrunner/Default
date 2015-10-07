using Fortius.Gui;

namespace Bakery.App.Views
{
    public partial class ViewGrid : ViewBase
    {
        private IGridSourceHost _viewModel;

        public ViewGrid()
        {
            InitializeComponent();
        }

        public override void Bind(object model)
        {
            base.Bind(model);
            _viewModel = model as IGridSourceHost;
            bindingSource.DataSource = _viewModel.GridSource;
        }

        public object Selected
        {
            get { return bindingSource.Current; }
            set { bindingSource.Position = bindingSource.IndexOf(value); }
        }

        private void bindingSource_CurrentChanged(object sender, System.EventArgs e)
        {
            _viewModel.Selected = bindingSource.Current;
        }
    }
}