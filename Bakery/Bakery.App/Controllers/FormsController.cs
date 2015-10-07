using System;
using System.Windows.Forms;
using Bakery.App.Views;
using Bakery.Model;
using Fortius.Gui;

namespace Bakery.App.Controllers
{
    internal class FormsController : Controller
    {
        protected static Form MainForm;

        public static void RegisterMainForm(Form mainForm)
        {
            MainForm = mainForm;
        }

        public void ShowReference<TViewModel, TView>()
            where TView : Control, IView, new()
            where TViewModel : IViewModel, new()
        {
            var form = new ViewLayout();
            Show<TViewModel, TView, ViewLayout>(form);
            form.Show(MainForm);
        }

        public void Show<TViewModel, TView>(params object[] vmParams)
            where TView : Control, IView, new()
            where TViewModel : IViewModel
        {
            var form = new ViewLayout();
            Show<TViewModel, TView, ViewLayout>(form, (TViewModel) Activator.CreateInstance(typeof (TViewModel), vmParams));
            form.Show(MainForm);
        }

        /*
        public TEntity Select<TEntity, TView>(TEntity item, string title)
            where TView : Control, ISelectorView<TEntity>, new()
            where TEntity : Entity
        {
            return ViewSelect<TEntity, TView, ViewLayoutSelector>(new ReferenceSource<TEntity>().DataSource, item, title);
        }*/
    }
}