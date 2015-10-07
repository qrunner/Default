using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.App.ViewModels.Filters
{
    public abstract class FilterViewModel
    {
        public FilterViewModel(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public abstract Expression<Func<Model.Invoice, bool>> FilterExpression { get;  }
    }
}