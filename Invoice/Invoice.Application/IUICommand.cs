using System;

namespace Sirius.Desktop
{
    public interface IUiCommand : ICommand
    {
        string Key { get; }

        string Category { get; }

        string Caption { get; }

        int Order { get; }

        event EventHandler<CommandExecutedEventArgs> CommandExecuted;
    }
}