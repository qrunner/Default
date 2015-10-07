using System;

namespace Fortius.Gui
{
    public class UiCommand : ICommand
    {
        private readonly Action<object> _action;
        private readonly Func<object, bool> _canExecute;

        public UiCommand(string name, Action<object> action, Func<object, bool> canExecute)
        {
            _action = action;
            _canExecute = canExecute;
            Name = name;
        }

        public UiCommand(string name, Action<object> action) : this(name, action, x => true)
        {
        }

        public void Execute(object parameter)
        {
            _action(parameter);
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute(parameter);
        }

        public string Name { get; private set; }
    }
}