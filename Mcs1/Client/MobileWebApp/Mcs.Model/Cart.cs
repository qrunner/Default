using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;

namespace Mcs.Model
{
    /// <summary>
    /// Элемент корзины блюд
    /// </summary>
    [Table(Name = "Dishes")]
    public class Cart
    {        
        /// <summary>
        /// Идентификтор элемента
        /// </summary>
        [Key]
        public int CartId { get; set; }

        /// <summary>
        /// Идентификтор устройства, к которому привязан элемент
        /// </summary>
        [Column]
        public string Device_Id { get; set; }

        /// <summary>
        /// Идентификтор блюда
        /// </summary>
        [Column]
        public int DishId { get; set; }

        /// <summary>
        /// Количество порций
        /// </summary>
        [Column]
        public int Quantity { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        [Column]
        public DateTime Creation_Date { get; set; }

        /// <summary>
        /// Блюдо
        /// </summary>
        [Column]
        public virtual Dish Dish { get; set; }
    }
}
