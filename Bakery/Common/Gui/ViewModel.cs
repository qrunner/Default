using System.Collections.Generic;

namespace Fortius.Gui
{
    public abstract class ViewModel : IViewModel
    {
        private readonly IDictionary<string, ICommand> _commands = new Dictionary<string, ICommand>();

        public void RegisterCommand(ICommand command)
        {
            _commands.Add(command.Name, command);
        }

        public IEnumerable<ICommand> Commands
        {
            get { return _commands.Values; }
        }

        public abstract bool HasChanges { get; }

        public abstract void Dispose();
    }
}