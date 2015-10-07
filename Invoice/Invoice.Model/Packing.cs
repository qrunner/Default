using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.Model
{
    /// <summary>
    /// Упаковка / тара
    /// </summary>
    public class Packing : NamedEntity
    {
        /// <summary>
        /// Описание
        /// </summary>
        [DisplayName("Описание")]
        public string Description { get { return MeasureUnit != null ? string.Format("{0} {1}{2}", Name, ItemsCount, MeasureUnit.ShortName) : Name; } }

        /// <summary>
        /// Единица измерения
        /// </summary>
        [DisplayName("Единица измерения")]
        public virtual MeasureUnit MeasureUnit { get; set; }

        /// <summary>
        /// Количество единиц в упаковке
        /// </summary>
        [DisplayName("Единиц в упаковке")]
        public int ItemsCount { get; set; }

        /// <summary>
        /// Тара многократного использования
        /// </summary>
        [DisplayName("Многоразовая тара")]
        public bool Reusable { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}