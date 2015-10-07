using System;
using System.Linq.Expressions;

namespace Invoice.App.ViewModels.Filters
{
    class ThisMonth : FilterViewModel
    {
        public ThisMonth() : base("В этом месяце") { }

        public override Expression<Func<Model.Invoice, bool>> FilterExpression
        {
            get
            {                
                return (x) => x.Date.Month == DateTime.Today.Month;
            }
        }
    }
}