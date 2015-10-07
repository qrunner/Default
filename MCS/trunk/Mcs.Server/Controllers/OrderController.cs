using Mcs.Model;

namespace Mcs.Server.Controllers
{
    public class OrderController : PlaceRelatedController<Order>
    {
        protected override void BeforeEdit(Order item)
        {
         
        }
    }
}
