using Invoice.Model;
using System.ComponentModel;
using System.Data.Entity;

namespace Invoice.App.ViewModels
{
    class MeasureUnitsViewModel : ListEditorViewModel
    {
        public override void Initialize(object parameter)
        {
            base.Initialize(parameter);

            DataContext.MeasureUnits.Load();
            MeasureUnits = DataContext.MeasureUnits.Local.ToBindingList();
        }

        public BindingList<MeasureUnit> MeasureUnits { get; private set; }

        public override IBindingList ListSource
        {
            get { return MeasureUnits; }
        }
    }
}