using System;
using System.Linq.Expressions;

namespace Invoice.App.ViewModels.Filters
{
    class ThisYear : FilterViewModel
    {
        public ThisYear() : base("В этом году") { }

        public override Expression<Func<Model.Invoice, bool>> FilterExpression
        {
            get
            {
                return (x) => x.Date.Year == DateTime.Today.Year;
            }
        }
    }
}