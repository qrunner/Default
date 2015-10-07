using System;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Sirius.Desktop.DevExpress.Bindings
{
    public class BarItemClickBinding : IDisposable
    {
        private readonly BarItem _control;
        private readonly IUiCommand _command;

        public BarItemClickBinding(BarItem control, IUiCommand command)
        {
            _control = control;
            _command = command;
            _control.ItemClick += _control_ItemClick;
            Application.Idle += Application_Idle;
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            _control.Enabled = _command.CanExecute(null);
        }

        private void _control_ItemClick(object sender, ItemClickEventArgs e)
        {
            _command.Execute(null);
        }

        public void Dispose()
        {
            _control.ItemClick -= _control_ItemClick;
            Application.Idle -= Application_Idle;
        }
    }
}