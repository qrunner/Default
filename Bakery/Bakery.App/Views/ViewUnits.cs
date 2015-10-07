using Bakery.Model;
using Fortius.Gui;

namespace Bakery.App.Views
{
    public sealed partial class ViewUnits : ViewGrid
    {
        public ViewUnits()
        {
            InitializeComponent();
        }

        public override void Bind(object model)
        {
            base.Bind(model);

            var viewModel = model as IReferenceHost;
            bsMeasureUnits.DataSource = viewModel.Reference<MeasureUnit>();
            bsUnitCategories.DataSource = viewModel.Reference<UnitCategory>();
        }
    }
}