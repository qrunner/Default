using System;

namespace Sirius.Desktop
{
    public abstract class UiCommandBase : IUiCommand
    {
        protected UiCommandBase(string key, string caption, string category = null, int order = -1)
        {
            Key = key;
            Caption = caption;
            Category = category;
            Order = order;
        }

        public string Key { get; private set; }

        public string Category { get; private set; }

        public string Caption { get; private set; }

        public int Order { get; private set; }

        public abstract void Execute(object parameter);

        public abstract bool CanExecute(object parameter);

        public event EventHandler<CommandExecutedEventArgs> CommandExecuted;

        public void UnsubscribeEventHandlers()
        {
            CommandExecuted = null;
        }

        protected void RaiseCommandExecuted()
        {
            var evh = CommandExecuted;
            if (evh != null)
                evh(this, new CommandExecutedEventArgs(this));
        }
    }
}