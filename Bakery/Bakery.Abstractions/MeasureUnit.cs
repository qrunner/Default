using System.ComponentModel;
using Accounting;

namespace Bakery.Model
{
    public class MeasureUnit : NamedEntity, IMeasureUnit
    {
        [DisplayName("Сокращение")]
        public string ShortName { get; set; }
    }
}