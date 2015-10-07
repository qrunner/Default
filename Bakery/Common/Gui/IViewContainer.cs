namespace Fortius.Gui
{
    public interface IViewContainer
    {
        void PlaceView(IView view);

        IView View { get; }
    }
}
