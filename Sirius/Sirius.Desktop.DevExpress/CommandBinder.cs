using DevExpress.XtraBars;
using Sirius.Desktop.DevExpress.Bindings;

namespace Sirius.Desktop.DevExpress
{
    public static class CommandBinder
    {
        public static void BindClick(this BarItem control, IUiCommand command)
        {
            if (CommandsBinder.Bindings.ContainsKey(control))
                CommandsBinder.Bindings[control].Dispose();

            CommandsBinder.Bindings[control] = new BarItemClickBinding(control, command);
        }

        public static void BindText(this BarEditItem control, object dataSource, string dataMember)
        {
            if (CommandsBinder.Bindings.ContainsKey(control))
                CommandsBinder.Bindings[control].Dispose();

            CommandsBinder.Bindings[control] = new BarEditItemTextBinding(control, dataSource, dataMember);
        }
    }
}