using Invoice.Model;
using System;

namespace Invoice.ServiceLayer.MySql
{
    public class ServiceFactory : IServiceFactory
    {
        private readonly string _contextName;

        public ServiceFactory(string contextName)
        {
            _contextName = contextName;
        }   

        public ServiceBase<T> GetService<T>() where T : Entity
        {
            return (ServiceBase<T>)Activator.CreateInstance(typeof(ServiceBase<T>), _contextName);
        }

        IService<T> IServiceFactory.GetService<T>()
        {
            return GetService<T>();
        }
    }
}
