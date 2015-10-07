using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;

namespace Mcs.Model
{
    [Table(Name = "Order")]
    public class Order
    {
        public int Id { get; set; }
        
        public int Desk_Id { get; set; }

        public int Device_Id { get; set; }

        public int State { get; set; }

        public DateTime Opened { get; set; }

        public DateTime Closed { get; set; }

        public IEnumerable<OrderDetail> Details { get; set; }
    }
}
