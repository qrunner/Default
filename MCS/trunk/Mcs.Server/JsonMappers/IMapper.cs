using System;
using Mcs.Model;

namespace Mcs.Server.JsonMappers
{
    public interface IMapper
    {
        TTo Map<TFrom, TTo>(TFrom obj);
    }

    public interface IMapper<TClass1, TClass2>
    {
        TClass2 Map(TClass1 obj);

        TClass1 Map(TClass2 obj);
    }

    /*internal class DeskMapper : IMapper<Desk, Model.Json.Desk>, IMapper
    {
    

        public Model.Json.Desk Map(Desk obj)
        {
            return new Model.Json.Desk
            {
                Id = obj.Id,
                Name = obj.Name,
                PlaceId = obj.PlaceId,
                Reserved = obj.Reserved
            };
        }

        public Desk Map(Model.Json.Desk obj)
        {
            return new Desk
            {
                Id = obj.Id,
                Name = obj.Name,
                PlaceId = obj.PlaceId,
                Reserved = obj.Reserved
            };
        }
    }*/
}