using System;
using System.Collections.Generic;
using System.Linq;

namespace Fortius.Gui
{
    public class Route
    {
        public static Route Create<TModel>(bool cacheable, params Type[] parameterTypes) where TModel : IViewModel
        {
            return new Route {Cacheable = cacheable, ModelType = typeof (TModel), ParameterTypes = parameterTypes};
        }

        public static Route Create(Type modelType, bool cacheable, params Type[] parameterTypes)
        {
            return new Route {Cacheable = cacheable, ModelType = modelType, ParameterTypes = parameterTypes};
        }

        public bool Cacheable { get; private set; }
        public Type ModelType { get; private set; }
        public IEnumerable<Type> ParameterTypes { get; private set; }

        public override string ToString()
        {
            return string.Format("{0}:{1}", ModelType, ParameterTypes.Aggregate("", (x, s) => x + "," + s));
        }
    }
}