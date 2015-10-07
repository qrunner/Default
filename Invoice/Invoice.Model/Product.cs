using System.ComponentModel;

namespace Invoice.Model
{
    /// <summary>
    /// Товар / продукция
    /// </summary>
    public class Product : NamedEntity
    {        
        /// <summary>
        /// Цена
        /// </summary>
        [DisplayName("Цена")]
        public decimal Price { get; set; }

        /// <summary>
        /// Единица измерения
        /// </summary>
        [DisplayName("Единица измерения")]
        public virtual MeasureUnit MeasureUnit { get; set; }
    }
}