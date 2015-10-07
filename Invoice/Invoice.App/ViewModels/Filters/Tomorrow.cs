using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.App.ViewModels.Filters
{
    class Tomorrow : FilterViewModel
    {
        public Tomorrow() : base("Завтра") { }
        
        public override Expression<Func<Model.Invoice, bool>> FilterExpression
        {
            get
            {
                var tomorrow = DateTime.Today.AddDays(1);
                return (x) => x.Date == tomorrow;
            }
        }
    }
}
