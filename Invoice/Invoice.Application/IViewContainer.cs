namespace Sirius.Desktop
{
    public interface IViewContainer
    {
        T PlaceView<T>(T view) where T : IView;
    }
}