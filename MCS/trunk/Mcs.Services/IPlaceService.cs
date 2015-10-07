using System.Collections.Generic;
using Mcs.Model;

namespace Mcs.Services
{    
    public interface IPlaceService : IServiceBase<Place>
    {        
        IEnumerable<Place> Get();
    }
}