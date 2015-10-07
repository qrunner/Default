using System.Windows.Forms;
using Bakery.App.Controllers;
using Bakery.App.Operations;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using Fortius.Gui;

namespace Bakery.App
{
    public partial class FrmMain : XtraForm
    {
        public FrmMain()
        {
            InitializeComponent();

            FormsController.RegisterMainForm(this);

            menuStrip1.Bind(new OperationController());

            Application.Idle += Application_Idle;
        }

        void Application_Idle(object sender, System.EventArgs e)
        {
            foreach (ToolStripItem item in tsContextCommands.Items)
            {
                var command = item.Tag as ICommand;
                if (command != null)
                    item.Enabled = command.CanExecute(null);
            }
        }

        private void eeeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void FrmMain_MdiChildActivate(object sender, System.EventArgs e)
        {
            IViewModel viewModel = null;
            var viewContainer = ActiveMdiChild as IViewContainer;
            if (viewContainer != null)
                viewModel = viewContainer.View.Model as IViewModel;
            
            if (viewModel != null)
                tsContextCommands.Bind(viewModel.Commands);
            else
                tsContextCommands.Items.Clear();
        }
    }
}