using System;
using System.ComponentModel;
using System.Linq;
using Bakery.Model;
using Fortius.Gui;

namespace Bakery.App.ViewModels
{
    internal class UnitEntryListVM : ViewModelBase, IGridSourceHost
    {
        public UnitEntryListVM(int siteId, UnitEntryListType listType)
        {
            var site = Context.Sites.Single(x => x.Id == siteId);

            switch (listType)
            {
                case UnitEntryListType.Income:
                    GridSource = new BindingList<UnitEntry>(site.Incoming.ToList());
                    break;
                case UnitEntryListType.Balance:
                    GridSource = new BindingList<UnitEntry>(site.Current.ToList());
                    break;
                case UnitEntryListType.Outcome:
                    GridSource = new BindingList<UnitEntry>(site.Outgoing.ToList());
                    break;
            }

            ListType = listType;
        }

        public UnitEntryListType ListType { get; private set; }

        public IBindingList GridSource { get; private set; }

        public object Selected { get; set; }

        public TimeFilter TimeFilter { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }
    }
}