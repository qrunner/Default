using System.Web.Http;
using Mcs.Model;
using Mcs.Services;
using Mcs.WebExtensions;

namespace Mcs.Server.Api
{
    public class BaseApiController<TModelEntity, TServiceInterface, TJsonEntity> : ApiController
        where TModelEntity : class, IEntity, new()
        where TJsonEntity : class, new()
        where TServiceInterface : class, IServiceBase<TModelEntity>
    {
        protected TServiceInterface ServiceInterface = Config.ServiceFactory.GetService<TServiceInterface>();

        protected IServiceBase<TModelEntity> Service
        {
            get { return ServiceInterface; }
        }

        public TJsonEntity Get(int id)
        {
            return Mapper.Map<TModelEntity, TJsonEntity>(ServiceInterface.Get(id));
        }
    }
}
