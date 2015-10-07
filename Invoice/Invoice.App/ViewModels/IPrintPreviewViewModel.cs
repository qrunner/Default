using Sirius.Desktop;

namespace Invoice.App.ViewModels
{
    public interface IPrintPreviewViewModel : IViewModel
    {
        object DocumentSource { get; }
    }
}