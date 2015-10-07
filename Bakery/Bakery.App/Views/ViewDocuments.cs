using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bakery.App.ViewModels;
using Fortius.Gui;

namespace Bakery.App.Views
{
    public partial class ViewDocuments : ViewBase
    {
        public ViewDocuments()
        {
            InitializeComponent();
        }

        public override void Bind(object model)
        {
            base.Bind(model);

            var viewModel = model as DocumentsListVM;
            bsDocuments.DataSource = viewModel.GridSource;
        }

        private void bsDocuments_CurrentChanged(object sender, EventArgs e)
        {
            (Model as IGridSourceHost).Selected = bsDocuments.Current;
            var viewModel = Model as DocumentsListVM;
            viewUnitEntries1.Bind(viewModel.UnitEntriesVM);
        }
    }
}
