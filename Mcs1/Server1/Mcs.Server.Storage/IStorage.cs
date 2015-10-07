using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mcs.Services.Storage
{
    /// <summary>
    /// 
    /// </summary>
    public interface IStorage<T>
    {
        T Get(int id);

        T Set(int id, T place);

        void Delete(int id);

        T Add(T place);
    }
}