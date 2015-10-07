using System;

namespace Bakery.App.Operations
{
    public class Command
    {
        public string Name { get; set; }

        public string Shortcut { get; set; }

        public override string ToString()
        {
            return string.Format("{0} ({1})", Name, Shortcut);
        }
        public Action Action { get; set; }
    }
}