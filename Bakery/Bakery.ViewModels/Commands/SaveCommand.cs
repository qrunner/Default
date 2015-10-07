using System.Data.Entity;
using Fortius.Gui;

namespace Bakery.UI.Commands
{
    public class SaveCommand : UiCommand
    {
        public SaveCommand(DbContext context)
            : base("Сохранить", x => context.SaveChanges(), x => context.ChangeTracker.HasChanges())
        {

        }
    }
}