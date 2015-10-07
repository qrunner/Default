using System.Collections.Generic;

namespace Mcs.Model
{
    /// <summary>
    /// Категория меню
    /// </summary>    
    public class MenuCategory : NamedEntity, IPlaceRelatedEntity
    {
        /// <summary>
        /// Идентификатор заведения
        /// </summary>
        public int PlaceId { get; set; }
                
        /// <summary>
        /// Идентификатор родительской категории
        /// </summary>
        public virtual int? ParentId { get; set; }

        /// <summary>
        /// Блюда категории
        /// </summary>
        public virtual ICollection<Dish> Dishes { get; set; }
    }
}