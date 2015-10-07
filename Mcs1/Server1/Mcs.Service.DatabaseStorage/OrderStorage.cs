using Mcs.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Provider.Database;
using Provider.Database.MySQL;
using System.Data;

namespace Mcs.Services.Storage.Database
{
    public class OrderStorage : StorageBase<Order>, IOrderStorage
    {
        private Func<IDataRecord, Order> ItemConstructor = r => new Order()
        {
            Id = Convert.ToInt32(r["id"]),
            DeskId = Convert.ToInt32(r["place_id"]),
            DeviceId = Convert.ToInt32(r["number"]),
            Opened = Convert.ToDateTime(r["number"]),
            Closed = Convert.ToDateTime(r["number"])            
        };

        public override Order Get(int id)
        {
            return Context.SelectSingle("SELECT id, place_id, number FROM desk where id = @id", ItemConstructor, new DbParamValue("id", id));
        }

        public override Order Set(int id, Order item)
        {
            Context.Execute("update desk set place_id = @placeid, number = @number where id = @id",
                new DbParamValue("id", id)
                //new DbParamValue("number", item.Number),
                //new DbParamValue("placeid", item.PlaceId)
                );

            item.Id = id;
            return item;
        }

        public override void Delete(int id)
        {
            Context.Execute("delete from desk where id = @id", new DbParamValue("id", id));
        }

        public override Order Add(Order item)
        {
            var id = Context.SelectValue("insert into desk (number, place_id) values (@number, @placeid); select last_insert_id();"
                //new DbParamValue("number", item.Number),
                //new DbParamValue("placeid", item.PlaceId)
                );
            item.Id = Convert.ToInt32(id);
            return item;
        }

        public IEnumerable<Order> GetAllOfPlace(int placeId, int skip, int take)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAll(int placeId, OrderState state, DateTime from, DateTime to, int skip, int take)
        {
            throw new NotImplementedException();
        }
    }
}