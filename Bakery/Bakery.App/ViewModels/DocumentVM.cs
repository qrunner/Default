using System.Collections.Generic;
using System.Linq;
using Bakery.Model;

namespace Bakery.App.ViewModels
{
    internal class DocumentVM : ViewModelBase
    {
        public DocumentVM(Context context, Document document) :
            base(context)
        {
            Document = document;
            DocumentTypes = Context.DocumentTypes.Where(x => x.Sites.Any(s => s.Id == Document.Site.Id)).ToList();

            UnitEntriesVM = new UnitEntriesVM(context, Document);
        }

        public Document Document { get; protected set; }

        public IList<DocumentType> DocumentTypes { get; private set; }

        public UnitEntriesVM UnitEntriesVM { get; private set; }
    }
}