using System;
using Bakery.App.ViewModels;

namespace Bakery.App.Views
{
    public partial class ViewEntryList : ViewGrid
    {
        public ViewEntryList()
        {
            InitializeComponent();
            imageComboBoxEdit1.Properties.Items.AddEnum<TimeFilter>();
        }

        public override void Bind(object model)
        {
            base.Bind(model);

            var vm = model as UnitEntryListVM;
            panelControl1.Visible = vm.ListType != UnitEntryListType.Balance;
        }
    }
}
