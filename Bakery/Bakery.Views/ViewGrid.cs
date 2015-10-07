using Fortius.Gui;

namespace Bakery.UI.WinForms
{
    public abstract class ViewGrid<TEntity> : ViewBase<IReferenceHostGridSource<TEntity>>
    {
        protected ViewGrid()
        {
            BindingSource.CurrentChanged += (s, e) => Model.Selected = (TEntity) BindingSource.Current;
        }
    }
}