using System.ComponentModel;

namespace Invoice.Model
{
    /// <summary>
    /// Запись в накладной
    /// </summary>
    public class InvoiceItem : Entity
    {
        /// <summary>
        /// Товар / продукция
        /// </summary>
        [DisplayName("Продукт")]
        public virtual Product Product { get; set; }

        /// <summary>
        /// Упаковка
        /// </summary>
        [DisplayName("Упаковка")]
        public virtual Packing Packing { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        [DisplayName("Количество")]
        public int Count { get; set; }

        /// <summary>
        /// Сумма
        /// </summary>
        [DisplayName("Сумма")]
        public decimal Amount
        {
            get
            {
                return Product != null ? (Product.Price * (Packing == null ? Count : Packing.ItemsCount * Count)) : 0;
            }
        }
    }
}