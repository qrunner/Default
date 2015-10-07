using Production;

namespace Bakery.Model.Implementation
{
    public class ProductEntry : UnitEntry, IProductInfo
    {
        public int ProductId
        {
            get { return Id; }
        }
    }
}