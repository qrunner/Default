using Bakery.Model;
using Fortius.Gui;

namespace Bakery.App.Views
{
    public interface ISelectorView<T> : IView
        where T : Entity
    {
        T Selected { get; set; }
    }
}