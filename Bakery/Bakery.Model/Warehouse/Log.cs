using System;
using System.Linq;
using Accounting;

namespace Bakery.Model.Warehouse
{
    public class Log : ILog<Entry>
    {
        public string Name
        {
            get { return "Журнал складских операций"; }
        }

        public Entry New()
        {
            throw new NotImplementedException();
        }

        public void Append(Entry record)
        {
            throw new NotImplementedException();
        }

        public void RemoveByOperation(OperationInfo operationInfo)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Entry> Records
        {
            get { throw new NotImplementedException(); }
        }
    }
}