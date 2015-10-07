using Accounting;

namespace Bakery.Model.Implementation
{
    public class MeasureUnit : NamedEntity, IMeasureUnit
    {
        public string ShortName { get; set; }
    }
}