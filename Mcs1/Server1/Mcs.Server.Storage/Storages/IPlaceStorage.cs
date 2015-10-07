using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mcs.DataModel;

namespace Mcs.Services.Storage
{
    public interface IPlaceStorage : IStorage<Place>
    {
        IEnumerable<Place> GetAll();
    }
}