using System.ComponentModel;
using System.Linq;
using Invoice.App.ViewModels;
using Invoice.Model;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Sirius.Desktop;
using Sirius.Desktop.DevExpress;

namespace Invoice.App.Views
{
    public partial class GridEditor : ViewBase
    {
        public GridEditor()
        {
            InitializeComponent();
        }

        protected void gridView1_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e)
        {
            GetModel<ListEditorViewModel>().CurrentEntity = (IEntity)e.Row;
        }

        public override void SetModel(IViewModel model)
        {
            base.SetModel(model);

            var mdl = GetModel<ListEditorViewModel>();            

            var command = mdl.UiCommands.Single(x => x.Key == "Edit");
            command.CommandExecuted -= command_CommandExecuted;
            command.CommandExecuted += command_CommandExecuted;

            mdl.ListSource.ListChanged -= ListSource_ListChanged;
            mdl.ListSource.ListChanged += ListSource_ListChanged;
        }

        void command_CommandExecuted(object sender, CommandExecutedEventArgs e)
        {
            ForceEditMode();
        }

        protected void ListSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
                GridView.FocusedRowHandle = e.NewIndex;

                ForceEditMode();
            }
        }

        private void ForceEditMode()
        {
            GridView.SelectRow(GridView.FocusedRowHandle);
            GridView.FocusedColumn = GridView.VisibleColumns[0];
            GridView.ShowEditor();
        }

        [Browsable(false)]
        protected virtual GridView GridView { get { return null; } }
    }
}
