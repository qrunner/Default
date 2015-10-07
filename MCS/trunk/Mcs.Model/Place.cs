using System.Collections.Generic;

namespace Mcs.Model
{
    /// <summary>
    /// Заведение
    /// </summary>    
    public class Place : NamedEntity
    {
        /// <summary>
        /// Новости заведения
        /// </summary>
        public virtual ICollection<News> News { get; set; }

        /// <summary>
        /// Акции заведения
        /// </summary>
        public virtual ICollection<Promo> Promos { get; set; }

        /// <summary>
        /// Столы заведения
        /// </summary>
        public virtual ICollection<Desk> Desks{ get; set; }

        /// <summary>
        /// Категории меню заведения
        /// </summary>
        public virtual ICollection<MenuCategory> MenuCategories { get; set; }

        /// <summary>
        /// Заказы
        /// </summary>
        public virtual ICollection<Order> Orders { get; set; }
    }
}