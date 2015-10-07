using System;
using System.Linq.Expressions;

namespace Invoice.App.ViewModels.Filters
{
    class Yesterday : FilterViewModel
    {
        public Yesterday() : base("Вчера") { }

        public override Expression<Func<Model.Invoice, bool>> FilterExpression
        {
            get
            {
                var yesterday = DateTime.Today.AddDays(-1);
                return (x) => x.Date == yesterday;
            }
        }
    }
}
