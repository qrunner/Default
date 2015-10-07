using System;

namespace Sirius.Desktop
{
    public abstract class RouteItemBase
    {
        protected RouteItemBase(IViewContainer container, ICommandsContainer commandsContainer, bool viewModelCashed)
        {
            Container = container;
            CommandsContainer = commandsContainer;
            ViewModelCashed = viewModelCashed;
        }

        /// <summary>
        /// Тип представления
        /// </summary>
        public abstract Type ViewType { get; }

        /// <summary>
        /// Тип модели представления
        /// </summary>
        public abstract Type ViewModelType { get; }

        /// <summary>
        /// Контейнер для представления
        /// </summary>
        public virtual IViewContainer Container { get; protected set; }

        public virtual ICommandsContainer CommandsContainer { get; protected set; }

        /// <summary>
        /// Можно ли кешировать ViewModel
        /// </summary>
        public bool ViewModelCashed { get; private set; }
    }
}