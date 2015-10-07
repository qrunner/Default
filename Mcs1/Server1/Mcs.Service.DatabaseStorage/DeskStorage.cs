using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mcs.DataModel;
using Provider.Database;
using Provider.Database.MySQL;
using System.Data;

namespace Mcs.Services.Storage.Database
{
    public class DeskStorage : StorageBase<Desk>, IDeskStorage
    {
        private Func<IDataRecord, Desk> ItemConstructor = r => new Desk()
        {
            Id = Convert.ToInt32(r["id"]),
            PlaceId = Convert.ToInt32(r["place_id"]),
            Number = Convert.ToString(r["number"])
        };

        public override Desk Get(int id)
        {
            return Context.SelectSingle("SELECT id, place_id, number FROM desk where id = @id", ItemConstructor, new DbParamValue("id", id));
        }

        public override Desk Set(int id, Desk item)
        {
            Context.Execute("update desk set place_id = @placeid, number = @number where id = @id",
                new DbParamValue("id", id),
                new DbParamValue("number", item.Number),
                new DbParamValue("placeid", item.PlaceId));

            item.Id = id;
            return item;
        }

        public override void Delete(int id)
        {
            Context.Execute("delete from desk where id = @id", new DbParamValue("id", id));
        }

        public override Desk Add(Desk item)
        {
            var id = Context.SelectValue("insert into desk (number, place_id) values (@number, @placeid); select last_insert_id();",
                new DbParamValue("number", item.Number),
                new DbParamValue("placeid", item.PlaceId));
            item.Id = Convert.ToInt32(id);
            return item;
        }        

        public IEnumerable<Desk> GetAll(int placeId)
        {
            return Context.Select("SELECT id, number, place_id FROM desk where place_id = @placeid", ItemConstructor, new DbParamValue("placeid", placeId));
        }
    }
}