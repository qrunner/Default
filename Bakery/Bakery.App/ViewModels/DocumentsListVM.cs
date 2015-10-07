using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using Bakery.App.Controllers;
using Bakery.App.Views;
using Bakery.Model;
using Fortius.Gui;

namespace Bakery.App.ViewModels
{
    internal class DocumentsListVM : ViewModelBase, IGridSourceHost
    {
        private readonly AccountingSite _site;
        private Document _selected;
        private readonly FormsController _controller = new FormsController();
        private readonly BindingList<Document> _gridSource;

        public DocumentsListVM(int siteId)
        {
            _site = Context.Sites.Single(s => s.Id == siteId);
            var docs = Context.Documents.Where(x => x.Site.Id == siteId);
            docs.Load();
            _gridSource = new BindingList<Document>(docs.ToList());

            RegisterCommand(new UiCommand("Провести", x => _selected.Accept(Context), x => _selected != null && !_selected.Accepted));
            RegisterCommand(new UiCommand("Добавить", x => _controller.Show<DocumentVM, ViewDocument>(Context, _site.NewDocument(Context)), x => true));
            RegisterCommand(new UiCommand("Удалить", x => _gridSource.Remove(_selected), x => _selected != null && !_selected.Accepted));
            RegisterCommand(new UiCommand("Редактировать", x => _controller.Show<DocumentVM, ViewDocument>(Context, _selected), x => _selected != null && !_selected.Accepted));
        }

        public IBindingList GridSource
        {
            get { return _gridSource; }
        }

        public object Selected
        {
            get { return _selected; }
            set
            {
                _selected = value as Document;
            }
        }

        public ICollection<UnitEntry> Items
        {
            get { return _selected.Items; }
        }

        public UnitEntriesVM UnitEntriesVM
        {
            get { return new UnitEntriesVM(Context, _selected); }
        }
    }
}