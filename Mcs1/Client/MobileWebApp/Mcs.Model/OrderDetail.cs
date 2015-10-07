using System.Data.Linq.Mapping;

namespace Mcs.Model
{
    [Table(Name = "OrderDetail")]
    public class OrderDetail
    {
        public int Id { get; set; }

        public Order Order { get; set; }

        public int Dish_Id { get; set; }

        public int Quantity { get; set; }
    }
}
