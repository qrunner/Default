using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.Model
{
    public interface INamedEntity : IEntity
    {
        [DisplayName("Наименование")]
        string Name { get; set; }
    }
}
