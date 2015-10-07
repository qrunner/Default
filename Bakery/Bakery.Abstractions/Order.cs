using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Model
{
    /// <summary>
    /// Заказ на изготовление продукции
    /// </summary>
    public class Order : OrderBase
    {
        /// <summary>
        /// Дата приема заказа
        /// </summary>
        public DateTime AcceptanceDate { get; set; }
        
        /// <summary>
        /// Заказчик
        /// </summary>
        public virtual Contractor Client { get; set; }

        /// <summary>
        /// Состав заказа
        /// </summary>
        public virtual ICollection<UnitEntry> Items { get; set; }
       
        /// <summary>
        /// Сумма заказа
        /// </summary>
        public decimal Amount
        {
            get { return Items.Sum(x => x.Amount); }
        }
    }
}