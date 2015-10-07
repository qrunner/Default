using System;

namespace Accounting
{
    /// <summary>
    /// Запись журнала проводок
    /// </summary>
    public interface IEntry
    {
        /// <summary>
        /// Идентификатор документа - основания
        /// </summary>
        int DocumentId { get; }

        /// <summary>
        /// Дата записи
        /// </summary>
        DateTime Date { get; set; }
    }
}