using System;
using System.ComponentModel;

namespace Invoice.Model
{
    public class NamedEntity : Entity, INamedEntity, IComparable
    {
        /// <summary>
        /// Наименование
        /// </summary>
        [DisplayName("Наименование")]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public int CompareTo(object obj)
        {
            return Name.CompareTo((obj as INamedEntity).Name);
        }
    }
}
