using System;
using Fortius.Domain;

namespace Accounting
{
    /// <summary>
    /// Документ - основание для проводки
    /// </summary>
    public interface IDocument : IEntity<int>
    {
        /// <summary>
        /// Номер документа, порядковый в контексте года
        /// </summary>
        int Number { get; set; }

        /// <summary>
        /// Дата
        /// </summary>
        DateTime Date { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        string Name { get; }

        /*/// <summary>
        /// Проводка
        /// </summary>
        //OperationInfo AcceptOperation { get; set; }*/
    }
}