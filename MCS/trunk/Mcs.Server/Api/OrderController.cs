using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Mcs.Model;
using Mcs.Services;

namespace Mcs.Server.Api
{
    public class OrderController : PlaceRelatedController<Order, Model.Json.Order>
    {
        private new IOrderService Service
        {
            get { return (IOrderService) base.Service; }
        }

        public void Post([FromBody] Model.Json.Order order)
        {
            Service.Save(Mapper.Map<Model.Json.Order, Order>(order));
        }

        public IEnumerable<Model.Json.Order> Device(int deviceId)
        {
            return Service.Get(x => x.DeviceId == deviceId).Select(Mapper.Map<Order, Model.Json.Order>);
        }

        [HttpGet]
        public IEnumerable<Model.Json.Order> Active(int deviceId)
        {
            return Service.Get(x => x.DeviceId == deviceId && x.State != OrderState.Closed).Select(Mapper.Map<Order, Model.Json.Order>);
        }

        public override IEnumerable<Model.Json.Order> Place(int placeId)
        {
            return Service.GetOfPlace(placeId).Select(Mapper.Map<Order, Model.Json.Order>);
        }
    }
}