using System;
using System.Collections.Generic;

namespace Fortius.Gui
{
    public interface IViewModel : IDisposable
    {
        void RegisterCommand(ICommand command);

        IEnumerable<ICommand> Commands { get; }

        bool HasChanges { get; }
    }
}