using System;
using System.Collections.Generic;

namespace Sirius.Desktop
{
    public static class CommandsBinder
    {
        public static readonly IDictionary<object, IDisposable> Bindings = new Dictionary<object, IDisposable>();
    }
}