using System.ComponentModel;
using System.Data.Entity;
using Fortius.Gui;

namespace Bakery.App.ViewModels
{
    /// <summary>
    /// Базовая модель для всех справочников
    /// </summary>
    internal class ReferenceVM<T> : ViewModelBase, IGridSourceHost
        where T : class
    {
        public ReferenceVM()
        {
            Context.Set<T>().Load();
            GridSource = Context.Set<T>().Local.ToBindingList();
            RegisterCommand(new UiCommand("Удалить", x => GridSource.Remove(Selected), x => Selected != null));
        }

        /// <summary>
        /// Источник данных для основной таблицы
        /// </summary>
        public IBindingList GridSource { get; protected set; }

        public object Selected { get; set; }
    }
}