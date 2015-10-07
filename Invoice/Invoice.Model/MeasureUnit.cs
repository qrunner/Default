using System.ComponentModel;

namespace Invoice.Model
{
    /// <summary>
    /// Единица измерения
    /// </summary>
    public class MeasureUnit : Entity
    {
        /// <summary>
        /// Наименование
        /// </summary>
        [DisplayName("Полное наименование")]
        public string FullName { get; set; }
 
        /// <summary>
        /// Сокращенное наименование
        /// </summary>
        [DisplayName("Краткое наименование")]
        public string ShortName { get; set; }
    }
}