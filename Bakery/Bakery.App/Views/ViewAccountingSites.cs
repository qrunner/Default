using Bakery.Model;
using Fortius.Gui;

namespace Bakery.App.Views
{
    public sealed partial class ViewAccountingSites : ViewGrid
    {
        public ViewAccountingSites()
        {
            InitializeComponent();
        }

        public override void Bind(object model)
        {
            base.Bind(model);

            var viewModel = model as IReferenceHost;
            bsCompanies.DataSource = viewModel.Reference<Company>();
        }
    }
}