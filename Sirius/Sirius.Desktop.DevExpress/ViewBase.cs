using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Sirius.Desktop.DevExpress
{
    public partial class ViewBase : XtraUserControl, IView
    {
        public ViewBase()
        {
            InitializeComponent();
        }

        protected static void PointerToControl(Control control)
        {
            control.Focus();

            var popup = control as PopupBaseEdit;
            if (popup != null)
                popup.ShowPopup();

            Cursor.Position = control.PointToScreen(new Point(control.Width / 2, control.Height / 2));

            control.Focus();
        }

        public virtual void SetModel(IViewModel model)
        {
            _model = model;
            bindingSource.DataSource = model;
        }

        private object _model;
        
        protected T GetModel<T>() { return (T)_model; }
    }
}