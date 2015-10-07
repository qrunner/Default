using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;

namespace Invoice.Model
{
    /// <summary>
    /// Накладная
    /// </summary>
    public class Invoice : Entity
    {
        public Invoice()
        {
            Items = new List<InvoiceItem>();
        }

        /// <summary>
        /// Дата
        /// </summary>        
        [DisplayName("Дата")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Производитель
        /// </summary>
        [DisplayName("Поставщик")]
        public virtual Producer Producer { get; set; }

        /// <summary>
        /// Продавец
        /// </summary>
        [DisplayName("Продавец")]
        public virtual Supplier Supplier { get; set; }

        /// <summary>
        /// Покупатель
        /// </summary>   
        [DisplayName("Клиент")]
        public virtual Customer Customer { get; set; }

        /// <summary>
        /// Основание
        /// </summary>
        [DisplayName("Основание")]
        public string Reason { get; set; }

        /// <summary>
        /// Состав накладной
        /// </summary>
        [DisplayName("Состав")]
        public virtual IList<InvoiceItem> Items { get; set; }

        /// <summary>
        /// Сумма накладной
        /// </summary>
        [DisplayName("Сумма")]
        public decimal Amount
        {
            get
            {
                if (Items == null || Items.Count == 0)
                    return 0;

                return Items.Sum(x => x.Amount);
            }
        }
    }
}