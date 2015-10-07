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
    public class PlaceStorage : StorageBase<Place>, IPlaceStorage
    {
        private Func<IDataRecord, Place> ItemConstructor = r => new Place()
        {
            Id = Convert.ToInt32(r["id"]),
            Name = Convert.ToString(r["name"])
        };

        public override Place Get(int id)
        {
            return Context.SelectSingle("SELECT id, name FROM place where id = @id", ItemConstructor, new DbParamValue("id", id));
        }

        public override Place Set(int id, Place place)
        {
            Context.Execute("update place set name = @name where id = @id",
                new DbParamValue("id", id),
                new DbParamValue("name", place.Name));

            place.Id = id;
            return place;
        }

        public override void Delete(int id)
        {
            Context.Execute("place_delete", true, new DbParamValue("placeid", id));
        }

        public override Place Add(Place place)
        {
            var id = Context.SelectValue("INsert into place (name) values (@placename); select last_insert_id();", new DbParamValue("placename", place.Name));
            place.Id = Convert.ToInt32(id);
            return place;
        }

        public IEnumerable<Place> GetAll()
        {
            return Context.Select("SELECT id, name FROM place", ItemConstructor);
        }
    }
}