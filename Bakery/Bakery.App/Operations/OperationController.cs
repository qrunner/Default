using System.Collections.Generic;
using System.Windows.Forms;
using Accounting;
using Bakery.App.Controllers;
using Bakery.App.ViewModels;
using Bakery.App.Views;
using Bakery.Model;
using Fortius.Gui;

namespace Bakery.App.Operations
{
    public class OperationController
    {
        private readonly CommandCategory[] _categories;
        private readonly FormsController _formsController;

        public OperationController()
        {
            _formsController = new FormsController();

            var references = new CommandCategory {Name = "СПРАВОЧНИКИ"};
            references.RegisterCommand(new UiCommand("Единицы измерения", x => _formsController.ShowReference<ReferenceVM<MeasureUnit>, ViewMeasureUnits>()));
            references.RegisterCommand(new UiCommand("Контрагенты", x => _formsController.ShowReference<ReferenceVM<Contractor>, ViewNamedEntity>()));
            references.RegisterCommand(new UiCommand("Организации", x => _formsController.ShowReference<ReferenceVM<Company>, ViewNamedEntity>()));
            references.RegisterCommand(new UiCommand("Категории ТМЦ", x => _formsController.ShowReference<ReferenceVM<UnitCategory>, ViewNamedEntity>()));
            references.RegisterCommand(new UiCommand("Товарно-материальные ценности", x => _formsController.ShowReference<ReferenceVM<Unit>, ViewUnits>()));
            references.RegisterCommand(new UiCommand("Участки учета", x => _formsController.ShowReference<ReferenceVM<AccountingSite>, ViewAccountingSites>()));
            references.RegisterCommand(new UiCommand("Типы документов", x => _formsController.ShowReference<ReferenceVM<DocumentType>, ViewDocumentTypes>()));
            references.RegisterCommand(new UiCommand("Рецепты", x => _formsController.ShowReference<ReferenceVM<Recipe>, ViewNamedEntity>()));

            var accountingSites = new CommandCategory {Name = "УЧЕТ"};

            using (var ctx = new Context())
            {
                foreach (var accountingSite in ctx.Sites)
                {
                    var site = accountingSite;

                    var siteCategory = new CommandCategory {Name = accountingSite.Name};
                    accountingSites.ChildItems.Add(siteCategory);

                    siteCategory.RegisterCommand(new UiCommand("Приход", x => _formsController.Show<UnitEntryListVM, ViewEntryList>(site.Id, UnitEntryListType.Income)));
                    siteCategory.RegisterCommand(new UiCommand("Наличие", x => _formsController.Show<UnitEntryListVM, ViewEntryList>(site.Id, UnitEntryListType.Balance)));
                    siteCategory.RegisterCommand(new UiCommand("Расход", x => _formsController.Show<UnitEntryListVM, ViewEntryList>(site.Id, UnitEntryListType.Outcome)));
                    siteCategory.RegisterCommand(new UiCommand("Документы", x => _formsController.Show<DocumentsListVM, ViewDocuments>(site.Id)));
                }
            }

            var settings = new CommandCategory {Name = "НАСТРОЙКИ"};

            var production = new CommandCategory {Name = "ПРОИЗВОДСТВО"};
            production.RegisterCommand(new UiCommand("Заказы", x => { }));
            production.RegisterCommand(new UiCommand("Наряды", x => { }));

            _categories = new[] {accountingSites, production, references, settings};
        }

        public IEnumerable<CommandCategory> Categories
        {
            get { return _categories; }
        }
    }
}