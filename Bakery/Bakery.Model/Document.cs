using System;
using Accounting;

namespace Bakery.Model.Implementation
{
    /// <summary>
    /// Базовый класс первичного документа
    /// </summary>
    public class Document : NamedEntity, IDocument
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public bool IsAccepted
        {
            get { return AcceptOperation != null; }
        }
        public OperationInfo AcceptOperation { get; set; }
    }
}