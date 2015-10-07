using System.ComponentModel;

namespace Fortius.Gui
{
    public interface IGridSource<T>
    {
        BindingList<T> GridSource { get; }

        T Selected { get; set; }
    }

    public interface IGridSourceHost
    {
        IBindingList GridSource { get; }

        object Selected { get; set; }
    }

    public interface IReferenceHostGridSource<T> : IGridSource<T>, IReferenceHost
    {
    }

    public interface IReferenceHost
    {
        IBindingList Reference<TRef>() where TRef : class;
    }
}