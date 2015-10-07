using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bakery.App.ViewModels;
using Bakery.Model;
using DevExpress.XtraGrid.Views.Grid;

namespace Bakery.App.Views
{
    public partial class ViewUnitEntries : ViewBase
    {
        private bool _editable = false;

        public ViewUnitEntries()
        {
            InitializeComponent();
        }

        public override void Bind(object model)
        {
            base.Bind(model);
            bindingSource.DataSource = (model as UnitEntriesVM).UnitEntryHost;
            bsUnits.DataSource = (model as ViewModelBase).Reference<Unit>();
        }

        public bool Editable
        {
            get { return _editable; }
            set
            {
                _editable = value;
                gridView1.OptionsView.NewItemRowPosition = _editable ? NewItemRowPosition.Top : NewItemRowPosition.None;
                gridView1.OptionsBehavior.Editable = _editable;
            }
        }
    }
}