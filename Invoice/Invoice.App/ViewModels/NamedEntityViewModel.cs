using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using Invoice.Model;
using System.ComponentModel;
using Invoice.App.Views;

namespace Invoice.App.ViewModels
{
    public class NamedEntityViewModel<T> : ListEditorViewModel, INamedEntityList where T : class, INamedEntity
    {
        public NamedEntityViewModel()
        {

        }

        public override void Initialize(object parameter)
        {
            base.Initialize(parameter);

            var dbSet = DataContext.Set<T>();
            dbSet.Load();
            Items = dbSet.Local.ToBindingList();
        }

        public IBindingList Items { get; private set; }

        public INamedEntity Current { get { return CurrentEntity as INamedEntity; } set { CurrentEntity = value; } }

        public override IBindingList ListSource
        {
            get { return Items; }
        }
    }
}