using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bakery.App.ViewModels;

namespace Bakery.App.Views
{
    public partial class ViewDocument : Bakery.App.Views.ViewBase
    {
        public ViewDocument()
        {
            InitializeComponent();
        }

        public override void Bind(object model)
        {
            base.Bind(model);

            var viewModel = model as DocumentVM;
            bsDocument.DataSource = viewModel.Document;
            bsTypes.DataSource = viewModel.DocumentTypes;
            viewUnitEntries1.Bind(viewModel.UnitEntriesVM);
        }
    }
}
