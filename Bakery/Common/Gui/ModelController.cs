using System;
using System.Collections.Generic;
using Fortius.Caching;

namespace Fortius.Gui
{
    public static class ModelController
    {
        private static readonly CachingFactory ModelsFactory = new CachingFactory();
        private static readonly IDictionary<string, Route> Routes = new Dictionary<string, Route>();
        
        public static void RegisterRoute(Route route)
        {
            RegisterRoute(route.ToString(), route);
        }

        public static void RegisterRoute(string name, Route route)
        {
            Routes.Add(name, route);
        }

        public static T GetModel<T>(string routeName, params object[] parameters) where T : class, IViewModel
        {
            return GetModel<T>(Routes[routeName], parameters);
        }

        public static T GetModel<T>(Route route, params object[] parameters) where T : class, IViewModel
        {
            Func<T> createMethod = () => (T) Activator.CreateInstance(typeof (T), parameters);

            return route.Cacheable ? ModelsFactory.Get(route.ToString(), createMethod) : createMethod.Invoke();
        }
    }
}