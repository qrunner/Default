using System;

namespace Sirius.Desktop
{
    public class RouteItem<TViewModel, TView> : RouteItemBase
        where TViewModel : IViewModel
        where TView : IView
    {
        public RouteItem(IViewContainer container, ICommandsContainer commandsContainer, bool viewModelCashed = true)
            : base(container, commandsContainer, viewModelCashed)
        {

        }

        public override Type ViewModelType { get { return typeof(TViewModel); } }

        public override Type ViewType { get { return typeof(TView); } }
    }
}