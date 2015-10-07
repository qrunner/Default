using System.Diagnostics;
using System.Windows.Forms;
using Bakery.App.Views;
using Bakery.Model;
using Fortius.Gui;

namespace Bakery.App
{
    public class Controller
    {

        /*public void ViewName<TView, TLayout>(object model)
            where TView : Control, IView, new()
            where TLayout : IViewLayout, new()
        {
            var layout = new TLayout();
            var view = new TView();
            view.Bind(model);
            layout.PlaceView(view);
            layout.Show(MainForm);
        }

        public TEntity ViewSelect<TEntity, TView, TLayout>(object model, TEntity selected, string title)
            where TView : Control, ISelectorView<TEntity>, new()
            where TEntity : Entity
            where TLayout : IViewLayout, new()
        {
            var view = new TView();
            view.Bind(model);
            view.Selected = selected;
            var form = new TLayout { Title = title };
            form.PlaceView(view);
            return form.ShowDialog(MainForm) == DialogResult.OK ? view.Selected : selected;
        }*/

        public void Show<TViewModel, TView, TViewContainer>(TViewContainer container, TViewModel model)
            where TViewContainer : IViewContainer
            where TView : IView, new()
            where TViewModel : IViewModel
        {
            var view = new TView();
            view.Bind(model);
            container.PlaceView(view);
        }

        public void Show<TViewModel, TView, TViewContainer>(TViewContainer container)
            where TViewContainer : IViewContainer
            where TView : IView, new()
            where TViewModel : IViewModel, new()
        {
            Show<TViewModel, TView, TViewContainer>(container, new TViewModel());
        }

        /*public void ShowChild<TViewModel, TView>()
            where TView : IView, new()
            where TViewModel : IViewModel, new()
        {
            var child = new ViewLayout();
            Show<TViewModel, TView, ViewLayout>(child);
            child.MdiParent = MainForm;
            child.Show();
        }*/
    }
}