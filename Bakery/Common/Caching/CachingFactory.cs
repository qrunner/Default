using System;
using System.Collections.Generic;

namespace Fortius.Caching
{
    public class CachingFactory
    {
        private readonly IDictionary<string, object> _items = new Dictionary<string, object>();

        public T Get<T>(string key) where T : class, new()
        {
            if (!_items.ContainsKey(key))
                _items.Add(key, new T());

            return (T) _items[key];
        }

        public T Get<T>(string key, Func<T> creator) where T : class
        {
            if (!_items.ContainsKey(key))
                _items.Add(key, creator());

            return (T) _items[key];
        }
    }
}