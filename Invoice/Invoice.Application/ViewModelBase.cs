using System.Collections.Generic;

namespace Sirius.Desktop
{
    public abstract class ViewModelBase : IViewModel
    {
        protected IDictionary<string, IUiCommand> MyUiCommands = new Dictionary<string, IUiCommand>();

        protected void RegisterCommand(IUiCommand command)
        {
            MyUiCommands.Add(command.Key, command);
        }

        public IEnumerable<IUiCommand> UiCommands
        {
            get { return MyUiCommands.Values; }
        }

        public abstract bool CanLeave();

        public abstract void Initialize(object parameter);

        protected static object ParseParam(object parameter, string propetyName)
        {
            return parameter.GetType().GetProperty(propetyName).GetValue(parameter, null);
        }
    }
}