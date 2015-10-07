using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Bakery.Model
{
    /// <summary>
    /// Участок учета
    /// </summary>
    public class AccountingSite : NamedEntity
    {
        /// <summary>
        /// Организация
        /// </summary>
        [DisplayName("Организация")]
        public virtual Company Company { get; set; }

        /// <summary>
        /// Наличие
        /// </summary>
        public virtual ICollection<UnitEntry> Current { get; set; }

        /// <summary>
        /// Приход
        /// </summary>
        public virtual ICollection<UnitEntry> Incoming { get; set; }

        /// <summary>
        /// Расход
        /// </summary>
        public virtual ICollection<UnitEntry> Outgoing { get; set; }

        /// <summary>
        /// Типы применимых документов
        /// </summary>
        public virtual ICollection<DocumentType> DocumentTypes { get; set; }

        /// <summary>
        /// Документы
        /// </summary>
        public virtual ICollection<Document> Documents { get; set; }

        public Document NewDocument(Context context)
        {
            var retval = new Document
            {
                Date = DateTime.Now,
                Number = context.Documents.Max(d => d.Number) + 1,
                Site = this
            };

            Documents.Add(retval);

            return retval;
        }

        /// <summary>
        /// Регистрирует приходную операцию
        /// </summary>
        /// <param name="entry"></param>
        public void Income(UnitEntry entry, Operation operation)
        {
            entry.Operation = operation;
            Incoming.Add(entry);
            Current.Add(entry);
        }

        /// <summary>
        /// Регистрирует расходную операцию
        /// Цены расхода равны ценам прихода
        /// Сначала расходуютсяя ранее оприходованные
        /// </summary>
        /// <param name="entry"></param>
        /// <param name="operation"></param>
        public void Outcom(UnitEntry entry, Operation operation)
        {
            CheckAvailable(entry);
            
            var actual = Current.Where(x => x.UnitId == entry.UnitId).OrderBy(x => x.Operation.Date).ToArray();

            var unitCountToGrab = entry.Count;

            foreach (var actualEntry in actual)
            {
                if (unitCountToGrab < actualEntry.Count)
                {
                    actualEntry.Count -= unitCountToGrab;
                    Outgoing.Add(new UnitEntry {Unit = actualEntry.Unit, Price = actualEntry.Price, Count = unitCountToGrab});
                    break;
                }
                Outgoing.Add(actualEntry);
                Current.Remove(actualEntry);
                actualEntry.Operation = operation;
                unitCountToGrab -= actualEntry.Count;
                if (unitCountToGrab == 0)
                    break;

                if (unitCountToGrab < 0)
                    throw new NotImplementedException("Ошибка в алгоритме перемещения с участка учета");
            }
        }

        public bool HasAvailable(IEnumerable<UnitCount> entries)
        {
            return entries.All(HasAvailable);
        }

        public bool HasAvailable(UnitCount entry)
        {
            return Current.Where(x => x.UnitId == entry.UnitId).Sum(x => x.Count) >= entry.Count;
        }

        private void CheckAvailable(UnitCount entry)
        {
            if (!HasAvailable(entry))
                throw new InvalidOperationException(string.Format("На участке учета '{0}' отсутствует {1}{2} {3}", Name, entry.Count, entry.Unit.MeasureUnit.ShortName, entry.Unit.Name));
        }
    }
}