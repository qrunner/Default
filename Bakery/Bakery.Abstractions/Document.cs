using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Accounting;

namespace Bakery.Model
{
    public class Document : Entity, IDocument, IUnitEntryHost
    {
        public Document()
        {
            Items = new List<UnitEntry>();
        }

        [DisplayName("Номер")]
        public int Number { get; set; }

        [DisplayName("Дата")]
        public DateTime Date { get; set; }

        [DisplayName("Наименование")]
        public string Name
        {
            get { return Type != null ? Type.Name : string.Empty; }
        }

        [DisplayName("Тип")]
        public virtual DocumentType Type { get; set; }

        public virtual AccountingSite Site { get; set; }

        public virtual IList<UnitEntry> Items { get; protected set; }

        [DisplayName("Сумма")]
        public decimal Amount
        {
            get { return Items != null ? Items.Sum(x => x.Amount) : 0; }
        }

        [DisplayName("Проведен")]
        public bool Accepted { get; protected set; }

        [DisplayName("Контрагент")]
        public virtual Contractor Contractor { get; set; }

        [DisplayName("Проведен")]
        public DateTime? AcceptedDate { get; protected set; }

        public void Accept(Context ctx)
        {
            if (Accepted)
                throw new InvalidOperationException("Документ уже проведен");

            var operation = ctx.OperationLog.Add(new Operation {Date = DateTime.Now, Document = this});
            if (Type.Operation == OperationType.Income) // income
            {
                foreach (var entry in Items)
                    Site.Income(entry, operation);
            }
            else // outcome
            {
                foreach (var entry in Items)
                {
                    Site.Outcom(entry, operation);
                }
            }

            Accepted = true;
            AcceptedDate = DateTime.Now;
        }

        public override string ToString()
        {
            return string.Format("{0} №{1} от {2:D}", Name, Number, Date);
        }
    }
}