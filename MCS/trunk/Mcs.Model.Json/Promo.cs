using System;

namespace Mcs.Model.Json
{
    /// <summary>
    /// Промо-акция
    /// </summary>
    public class Promo : Entity
    {
        /// <summary>
        /// Идентификатор заведения
        /// </summary>
        public int PlaceId { get; set; }

        /// <summary>
        /// Заголовок / название
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Дата начала
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Дата окончания
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Видимость
        /// </summary>
        public bool Visible { get; set; }
    }
}