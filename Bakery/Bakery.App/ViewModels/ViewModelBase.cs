using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using Bakery.Model;
using Fortius.Gui;

namespace Bakery.App.ViewModels
{
    class ViewModelBase : ViewModel, IReferenceHost
    {
        protected Context Context;

        private readonly IDictionary<Type, IBindingList> _references = new Dictionary<Type, IBindingList>();

        protected ViewModelBase(Context context)
        {
            Context = context;
            RegisterCommand(new UiCommand("Сохранить", x => Context.SaveChanges(), x => Context.ChangeTracker.HasChanges()));
        }

        public ViewModelBase() : this(new Context())
        {
        }

        public override bool HasChanges
        {
            get { return Context.ChangeTracker.HasChanges(); }
        }

        public override void Dispose()
        {
            Context.Dispose();
        }
        
        public IBindingList Reference<TRef>() where TRef : class
        {
            var type = typeof(TRef);

            if (!_references.ContainsKey(type))
            {
                Context.Set<TRef>().Load();
                _references.Add(type, Context.Set<TRef>().Local.ToBindingList());
            }

            return _references[type];
        }
    }
}
