using System.ComponentModel;

namespace Bakery.Model
{
    /// <summary>
    /// Единица ТМЦ
    /// </summary>
    public class Unit : NamedEntity
    {
        /// <summary>
        /// Идентификатор категории
        /// </summary>
        //public int UnitCategoryId { get; set; }
        
        /// <summary>
        /// Категория
        /// </summary>
        [DisplayName("Категория")]
        public virtual UnitCategory UnitCategory { get; set; }

        /// <summary>
        /// Идентификатор единицы измерения
        /// </summary>
        //public int MeasureUnitId { get; set; }

        /// <summary>
        /// Единица измерения
        /// </summary>
        [DisplayName("Единица измерения")]
        public virtual MeasureUnit MeasureUnit { get; set; }

        /// <summary>
        /// Продукт
        /// </summary>
        [DisplayName("Продукт")]
        public bool IsProduct { get; set; }

        /// <summary>
        /// Сырье
        /// </summary>
        [DisplayName("Сырье")]
        public bool IsRaw { get; set; }
    }
}
