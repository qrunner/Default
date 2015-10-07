using System;

namespace Accounting.Metadata
{
    [AttributeUsage(validOn: AttributeTargets.Class, AllowMultiple = false)]
    public class NameAttribute : Attribute
    {
        public NameAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public static string FromInstance(object obj)
        {
            var attr = obj.GetType().GetCustomAttributes(typeof (NameAttribute), true);
            if (attr.Length > 0)
                return ((NameAttribute) attr[0]).Name;

            throw new InvalidOperationException(string.Format("Экземпляр типа {0} не имеет атрибута {1}", obj.GetType(), typeof (NameAttribute)));
        }
    }
}