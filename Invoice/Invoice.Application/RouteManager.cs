using System;
using System.Collections.Generic;

namespace Sirius.Desktop
{
    public class RouteManager
    {
        private readonly CashedFactory _cashe = new CashedFactory();

        private readonly IDictionary<string, RouteItemBase> _routes = new Dictionary<string, RouteItemBase>();

        public void RegisterRoute(string path, RouteItemBase route)
        {
            _routes.Add(path, route);
        }

        public void RedirectToRoute(string path, object parameter = null)
        {
            RedirectToRouteInternal(path, parameter);
            AddToHistory(new Tuple<string, object>(path, parameter));
        }

        private void RedirectToRouteInternal(string path, object parameter = null)
        {
            var route = _routes[path];

            var view = (IView) _cashe.Get(route.ViewType.AssemblyQualifiedName, () => Activator.CreateInstance(route.ViewType));

            var viewModel = GetViewModel(path);

            viewModel.Initialize(parameter);
            view.SetModel(viewModel);

            route.Container.PlaceView(view);
            if (route.CommandsContainer != null)
                route.CommandsContainer.PlaceCommands(viewModel);

            CurrentPath = path;
        }

        public IViewModel GetViewModel(string path)
        {
            var route = _routes[path];

            IViewModel viewModel;
            if (route.ViewModelCashed)
            {
                viewModel = (IViewModel) _cashe.Get(route.ViewModelType.AssemblyQualifiedName, () => CreateViewModel(route.ViewModelType, path));
            }
            else
            {
                viewModel = (IViewModel)CreateViewModel(route.ViewModelType, path);
            }
            return viewModel;
        }

        private object CreateViewModel(Type type, string path)
        {
            var vm = Activator.CreateInstance(type);
            if (_commandBindings.ContainsKey(path))
                _commandBindings[path].Invoke(vm);
            return vm;
        }

        private readonly List<Tuple<string, object>> _history = new List<Tuple<string, object>>();

        private const int HistoryLength = 10;

        private int _historyPosition = 0;

        private void AddToHistory(Tuple<string, object> route)
        {
            /*if (HistoryPosition < _history.Count - 1)
                for (int i = HistoryPosition + 1; i < _history.Count; i++)
                {
                    _history.RemoveAt(HistoryPosition + 1);
                }*/

            if (_history.Count == HistoryLength)
                _history.RemoveAt(0);

            _history.Add(route);

            _historyPosition = _history.Count - 1;
        }

        public bool CanForward
        {
            get { return _historyPosition < _history.Count - 1 && _historyPosition >= 0; }
        }

        public bool CanBack
        {
            get { return _historyPosition > 0 && _historyPosition < _history.Count; }
        }

        public void MoveForward()
        {
            if (!CanForward) return;

            _historyPosition++;
            var route = _history[_historyPosition];
            RedirectToRouteInternal(route.Item1, route.Item2);
        }

        public void MoveBack()
        {
            if (!CanBack) return;

            _historyPosition--;
            var route = _history[_historyPosition];
            RedirectToRouteInternal(route.Item1, route.Item2);
        }

        public string CurrentPath { get; private set; }

        private readonly IDictionary<string, Action<object>> _commandBindings = new Dictionary<string, Action<object>>();

        public void RegisterCommandBindings<TViewModel>(string path, Action<TViewModel> registerAction) where TViewModel : class, IViewModel
        {
            if (!_commandBindings.ContainsKey(path))
            {
                _commandBindings[path] = x => registerAction((TViewModel) x);
            }
        }
    }
}