using Invoice.Model;
using System.ComponentModel;
using Sirius.Desktop;

namespace Invoice.App.ViewModels
{
    public abstract class ListEditorViewModel : ViewModel
    {
        protected ListEditorViewModel()
        {
            RegisterCommand(new ActionCommand("Add", x => AddNew(), x => true, "Создать", CategoryOperations));
            RegisterCommand(new ActionCommand("Edit", x => EditCurrent(), x => CurrentEntity != null, "Редактировать", CategoryOperations));
            RegisterCommand(new ActionCommand("Delete", x => DeleteCurrent(), x => CurrentEntity != null, "Удалить", CategoryOperations));
            RegisterCommand(new ActionCommand("Save", x => Save(), x => DataContext.IsChanged, "Сохранить", CategoryOperations, 10));
        }
        
        protected virtual void AddNew()
        {
            ListSource.AddNew();
        }

        protected virtual void DeleteCurrent()
        {
            ListSource.Remove(CurrentEntity);
        }

        protected virtual void EditCurrent()
        {

        }

        public IEntity CurrentEntity { get; set; }

        public abstract IBindingList ListSource { get; }
    }
}