using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Fortius.Gui;

namespace Bakery.App.Views
{
    public partial class ViewLayout : XtraForm, IViewLayout, IViewContainer
    {
        public ViewLayout()
        {
            InitializeComponent();
        }

        public string Title { get; set; }

        public void PlaceView<T>(T view) where T : Control, IView
        {
            view.Parent = container;
            view.Dock = DockStyle.Fill;
        }

        public void Show(Form mdiParent)
        {
            MdiParent = mdiParent;
            Show();
        }

        public void PlaceView(IView view)
        {
            var control = view as Control;
            if (control == null)
                throw new ArgumentException("view");

            control.Parent = container;
            control.Dock = DockStyle.Fill;

            View = view;
        }

        public IView View { get; private set; }

        private void ViewLayout_FormClosing(object sender, FormClosingEventArgs e)
        {
            var viewModel = View.Model as IViewModel;

            if (viewModel != null && viewModel.HasChanges)
            {
                if (MessageBox.Show(this, @"Имеются несохраненные изменения. Закрыть окно?", @"Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}