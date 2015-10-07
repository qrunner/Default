using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Mcs.DataModel;
using Provider.Database;
using Provider.Database.MySQL;

namespace Mcs.Services.Storage.Database
{
    public class DishStorage : StorageBase<Dish>, IDishStorage
    {
        private Func<IDataRecord, Dish> ItemConstructor = r => new Dish()
        {
            Id = Convert.ToInt32(r["id"]),
            CategoryId = Convert.ToInt32(r["mcat_id"]),
            Description = ReaderConvert.ToString(r["description"]),
            Name = Convert.ToString(r["name"]),
            Price = Convert.ToDecimal(r["price"])
        };

        public override Dish Get(int id)
        {
            return Context.SelectSingle(@"SELECT * FROM dish where id = @id",
            ItemConstructor, new DbParamValue("id", id));
        }

        public override Dish Set(int id, Dish item)
        {
            Context.Execute(@"update dish set 
                                mcat_id = @mcat_id, 
                                description = @description, 
                                name = @name,
                                price = @price
                                where id = @id",
                new DbParamValue("id", id),
                new DbParamValue("name", item.Name),
                new DbParamValue("mcat_id", item.CategoryId),
                new DbParamValue("description", item.Description),
                new DbParamValue("price", item.Price));

            item.Id = id;
            return item;
        }

        public override void Delete(int id)
        {
            Context.Execute("delete from dish where id = @id", new DbParamValue("id", id));
        }

        public override Dish Add(Dish item)
        {
            var id = Context.SelectValue(@"insert into dish
                            ( mcat_id,  name,  description,  price, archived) values 
                            (@mcat_id, @name, @description, @price, 0);
                            select last_insert_id();",
                new DbParamValue("name", item.Name),
                new DbParamValue("mcat_id", item.CategoryId),
                new DbParamValue("description", item.Description),
                new DbParamValue("price", item.Price, DbParamType.Decimal));
            item.Id = Convert.ToInt32(id);
            return item;
        }

        public IEnumerable<Dish> GetAllOfPlace(int placeId)
        {
            return Context.Select(@"SELECT dish.* FROM dish
                                    join mcat on mcat_id = mcat.id
                                    where mcat.place_id =  @place_id", ItemConstructor,
                new DbParamValue("place_id", placeId));
        }

        public IEnumerable<Dish> GetAllOfCategory(int categoryId)
        {
            return Context.Select("SELECT * FROM dish where mcat_id = @mcat_id", ItemConstructor,
                new DbParamValue("mcat_id", categoryId));
        }
    }
}