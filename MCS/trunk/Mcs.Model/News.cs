using System;

namespace Mcs.Model
{
    /// <summary>
    /// Новость
    /// </summary>
    public class News : Entity, IPlaceRelatedEntity
    {
        /// <summary>
        /// Идентификатор заведения
        /// </summary>
        public int PlaceId { get; set; }

        /// <summary>
        /// Заголовок
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Краткое описание 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Содержимое
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Дата
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Видимость
        /// </summary>
        public bool Visible { get; set; }
    }
}