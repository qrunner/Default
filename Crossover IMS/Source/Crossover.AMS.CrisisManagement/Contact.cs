using Crossover.AMS.Contracts;
using System.ComponentModel.DataAnnotations;

namespace Crossover.AMS.CrisisManagement
{
    public class Contact : Entity, IContact
    {
        [UIHint("Enumeration")]
        public ContactCategory Category { get; set; }

        public ContactType Type { get; set; }
        public string Value { get; set; }
    }
}