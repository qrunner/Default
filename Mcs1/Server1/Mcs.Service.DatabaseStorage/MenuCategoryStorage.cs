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
    public class MenuCategoryStorage : StorageBase<MenuCategory>, IMenuCategoryStorage
    {
        private Func<IDataRecord, MenuCategory> ItemConstructor = r => new MenuCategory()
        {
            Id = Convert.ToInt32(r["id"]),
            PlaceId = Convert.ToInt32(r["place_id"]),
            ParentId = ReaderConvert.ToIntegerNullable(r["parent_id"]),
            Name = Convert.ToString(r["name"])
        };

        public override MenuCategory Get(int id)
        {
            return Context.SelectSingle("SELECT id, place_id, parent_id, name FROM mcat where id = @id", ItemConstructor,
                new DbParamValue("id", id));
        }

        public override MenuCategory Set(int id, MenuCategory item)
        {
            Context.Execute("update mcat set parent_id = @parent_id, place_id = @place_id, name = @name where id = @id",
                new DbParamValue("id", id),
                new DbParamValue("name", item.Name),
                new DbParamValue("parent_id", item.ParentId),
                new DbParamValue("place_id", item.PlaceId));

            item.Id = id;
            return item;
        }

        public override void Delete(int id)
        {
            Context.Execute("delete from mcat where id = @id", new DbParamValue("id", id));
        }

        public override MenuCategory Add(MenuCategory item)
        {
            var id = Context.SelectValue("insert into mcat (name, parent_id, place_id) values (@name, @parent_id, @place_id); select last_insert_id();",
                new DbParamValue("name", item.Name),
                new DbParamValue("parent_id", item.ParentId),
                new DbParamValue("place_id", item.PlaceId));
            item.Id = Convert.ToInt32(id);
            return item;
        }

        public IEnumerable<MenuCategory> GetAll(int placeId)
        {
            return Context.Select("SELECT id, name, parent_id, place_id FROM mcat where place_id = @placeid", ItemConstructor, 
                new DbParamValue("placeid", placeId));
        }
    }
}