using System.Collections.Generic;

namespace Sirius.Desktop
{
    public interface IViewModel
    {
        void Initialize(object parameter);

        IEnumerable<IUiCommand> UiCommands { get; }

        /// <summary>
        /// Проверяет, можно ли покидать представление в данный момент
        /// </summary>
        /// <returns>True - если представление можно безопасно покинуть, false - в противном случае</returns>
        bool CanLeave();
    }
}