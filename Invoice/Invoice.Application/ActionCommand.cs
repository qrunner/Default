using System;

namespace Sirius.Desktop
{
    public class ActionCommand : UiCommandBase
    {
        private readonly Action<object> _action;
        private readonly Func<object, bool> _canExecute;

        public ActionCommand(string key, Action<object> action, Func<object, bool> canExecute, string caption, string category = null, int order = -1) :
            base(key, caption, category, order)
        {
            _action = action;
            _canExecute = canExecute;
        }

        public override bool CanExecute(object parameter)
        {
            return _canExecute(parameter);
        }

        public override void Execute(object parameter)
        {
            _action(parameter);

            RaiseCommandExecuted();
        }
    }
}