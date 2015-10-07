using Invoice.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.App.ViewModels
{
    public class PackingViewModel : ListEditorViewModel
    {
        public override void Initialize(object parameter)
        {
            base.Initialize(parameter);

            DataContext.Packings.Load();
            DataContext.MeasureUnits.Load();
            Packings = DataContext.Packings.Local.ToBindingList();
            MeasureUnits = DataContext.MeasureUnits.Local.ToBindingList();
        }

        public BindingList<Model.Packing> Packings { get; private set; }

        public BindingList<MeasureUnit> MeasureUnits { get; private set; }

        public override IBindingList ListSource
        {
            get
            {
                return Packings;
            }
        }
    }
}