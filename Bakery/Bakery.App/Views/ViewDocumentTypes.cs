using System;
using System.Collections.Generic;
using System.Linq;
using Accounting;
using Bakery.Model;
using Fortius.Gui;

namespace Bakery.App.Views
{
    public sealed partial class ViewDocumentTypes : ViewGrid
    {
        private const char Separator = ',';

        public ViewDocumentTypes()
        {
            InitializeComponent();

            gridControl2.ForceInitialize();

            repositoryItemImageComboBox1.Items.AddEnum<OperationType>(e => e == OperationType.Income ? "Приход" : "Расход");
        }

        public override void Bind(object model)
        {
            base.Bind(model);

            var viewModel = model as IReferenceHost;
            bsSites.DataSource = viewModel.Reference<AccountingSite>();
        }

        public string GetDisplayText(IEnumerable<AccountingSite> sites)
        {
            return sites!= null? sites.Aggregate("", (acc, site) => string.Format("{0}{1}{2} ", acc, site.Name, Separator)).TrimEnd(Separator, ' ') : string.Empty;
        }

        public void SetValue(string sites, DocumentType docType)
        {
            var viewModel = Model as IReferenceHost;
            var names = sites.Split(new[] { Separator }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim());

            docType.Sites.Clear();
            foreach (var site in viewModel.Reference<AccountingSite>().Cast<AccountingSite>().Where(x => names.Contains(x.Name)))
                docType.Sites.Add(site);
        }

        private void gridView2_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column != colSites) return;

            if (e.IsGetData)
                e.Value = GetDisplayText((e.Row as DocumentType).Sites);
            if (e.IsSetData)
                SetValue(e.Value.ToString(), e.Row as DocumentType);
        }
    }
}