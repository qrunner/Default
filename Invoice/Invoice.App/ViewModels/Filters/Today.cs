using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.App.ViewModels.Filters
{
    public class Today : FilterViewModel
    {
        public Today() : base("Сегодня") { }
        public override Expression<Func<Model.Invoice, bool>> FilterExpression
        {
            get
            {
                var today = DateTime.Today;
                return (x) => x.Date == today;
            }
        }
    }
}