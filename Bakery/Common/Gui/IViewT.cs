namespace Fortius.Gui
{
    public interface IView<in T>
    {
        void Bind(T model);
    }
}
