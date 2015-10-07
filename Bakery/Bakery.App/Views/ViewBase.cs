using DevExpress.XtraEditors;
using Fortius.Gui;

namespace Bakery.App.Views
{
    public partial class ViewBase : XtraUserControl, IView
    {
        public ViewBase()
        {
            InitializeComponent();
        }

        public virtual void Bind(object model)
        {
            Model = model;
        }

        public object Model { get; private set; }
    }
}