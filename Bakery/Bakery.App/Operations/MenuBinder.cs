using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Fortius.Gui;

namespace Bakery.App.Operations
{
    public static class MenuBinder
    {
        public static void Bind(this MenuStrip menu, OperationController controller)
        {
            menu.Items.Clear();
            foreach (var category in controller.Categories)
            {
                ((ToolStripMenuItem) menu.Items.Add(category.Name)).Bind(category);
            }
        }

        private static void Bind(this ToolStripDropDownItem menuItem, CommandCategory commandCategory)
        {
            menuItem.Name = commandCategory.Name;

            foreach (var command in commandCategory.Commands.ToArray())
            {
                var cmd = command;
                var mi = menuItem.DropDownItems.Add(command.Name) as ToolStripMenuItem;
                //mi.ShortcutKeyDisplayString = command.Shortcut;
                mi.Click += (sender, e) => cmd.Execute(sender);
            }

            foreach (var category in commandCategory.ChildItems)
            {
                ((ToolStripMenuItem) menuItem.DropDownItems.Add(category.Name)).Bind(category);
            }
        }

        public static void Bind(this ToolStrip bar, IEnumerable<ICommand> commands)
        {
            bar.Items.Clear();
            foreach (var command in commands)
            {
                var item = bar.Items.Add(command.Name);
                var cmd = command;
                item.Click += (sender, e) => cmd.Execute(sender);
                item.Tag = cmd;
            }
        }
    }
}