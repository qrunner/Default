using System;
using System.ComponentModel;
using Accounting;

namespace Bakery.Model
{
    public class Operation : Entity
    {
        [DisplayName("Дата")]
        public DateTime Date { get; set; }

        [DisplayName("Документ")]
        public virtual Document Document { get; set; }
    }
}
