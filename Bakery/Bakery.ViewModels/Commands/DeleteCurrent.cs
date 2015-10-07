using Fortius.Gui;

namespace Bakery.UI.Commands
{
    public class DeleteCurrent<T> : UiCommand where T:class
    {
        public DeleteCurrent(IGridSource<T> gridSourceHost) :
            base("Удалить", x => gridSourceHost.GridSource.Remove(gridSourceHost.Selected), x => gridSourceHost.Selected != null)
        {

        }
    }
}