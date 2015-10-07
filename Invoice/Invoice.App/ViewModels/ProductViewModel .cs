using Invoice.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Invoice.App.ViewModels
{
    public class ProductViewModel : ListEditorViewModel
    {
        public override void Initialize(object parameter)
        {
            base.Initialize(parameter);

            DataContext.Products.Load();
            DataContext.MeasureUnits.Load();           
            
            Products = DataContext.Products.Local.ToBindingList();
            MeasureUnits = DataContext.MeasureUnits.Local.ToBindingList();            
        }  

        public BindingList<Product> Products { get; private set; }

        public BindingList<MeasureUnit> MeasureUnits { get; private set; }

        public override IBindingList ListSource
        {
            get
            {
                return Products;
            }
        }
    }
}
