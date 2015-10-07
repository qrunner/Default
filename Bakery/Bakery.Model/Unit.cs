namespace Bakery.Model.Implementation
{
    /// <summary>
    /// Единица ТМЦ
    /// </summary>
    public class Unit : NamedEntity
    {
        /// <summary>
        /// Идентификатор категории
        /// </summary>
        public int UnitCategoryId { get; set; }
        
        /// <summary>
        /// Категория
        /// </summary>
        public virtual UnitCategory UnitCategory { get; set; }

        /// <summary>
        /// Идентификатор единицы измерения
        /// </summary>
        public int MeasureUnitId { get; set; }

        /// <summary>
        /// Единица измерения
        /// </summary>
        public virtual MeasureUnit MeasureUnit { get; set; }

        /// <summary>
        /// Продукт
        /// </summary>
        public bool IsProduct { get; set; }

        /// <summary>
        /// Сырье
        /// </summary>
        public bool IsRaw { get; set; }
    }
}
