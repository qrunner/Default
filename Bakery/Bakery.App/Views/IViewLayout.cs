using System.Windows.Forms;
using Fortius.Gui;

namespace Bakery.App.Views
{
    /// <summary>
    /// Контейнер для размещения представления
    /// </summary>
    public interface IViewLayout
    {
        string Title { get; set; }

        void PlaceView<T>(T view) where T : Control, IView;

        void Show(Form mdiParent);

        DialogResult ShowDialog(IWin32Window parent);
    }
}