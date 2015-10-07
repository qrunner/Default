using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Provider.Database;

namespace Mcs.Services.Storage.Database
{
    public abstract class StorageBase<T>
    {
        protected DatabaseContext Context = new DatabaseContext("DefaultProvider");

        public abstract T Get(int id);

        public abstract T Set(int id, T place);

        public abstract void Delete(int id);

        public abstract T Add(T place);
    }
}