using System.Collections.Generic;
using Crossover.AMS.Models;

namespace Crossover.AMS.Communication.Models
{
    public class AccidentCategory : Entity
    {
        public virtual AccidentCategory ParentCategory { get; set; }

        public virtual ICollection<AccidentCategory> ChildCategories { get; set; }
    }
}