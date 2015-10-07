using System.ComponentModel;
using System.Data.Entity;
using Bakery.UI.Commands;
using Fortius.Gui;

namespace Bakery.UI
{
    /// <summary>
    /// Базовая модель для справочников
    /// </summary>
    public class Reference<T> : ViewModelBase, IGridSource<T> where T : class
    {
        public Reference()
        {
            Context.Set<T>().Load();
            GridSource = Context.Set<T>().Local.ToBindingList();

            RegisterCommand(new SaveCommand(Context));
            RegisterCommand(new DeleteCurrent<T>(this));
        }

        public BindingList<T> GridSource { get; set; }

        public T Selected { get; set; }
    }
}