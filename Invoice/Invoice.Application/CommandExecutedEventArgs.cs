using System;

namespace Sirius.Desktop
{
    public class CommandExecutedEventArgs : EventArgs
    {
        public CommandExecutedEventArgs(IUiCommand command)
        {
            Command = command;
        }

        public IUiCommand Command { get; private set; }
    }
}