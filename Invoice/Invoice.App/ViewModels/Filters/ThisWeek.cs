using System;
using System.Linq.Expressions;

namespace Invoice.App.ViewModels.Filters
{
    class ThisWeek : FilterViewModel
    {
        public ThisWeek() : base("На этой неделе") { }

        public override Expression<Func<Model.Invoice, bool>> FilterExpression
        {
            get
            {
                var thisWeekEnd = DateTime.Today.AddDays(7 - (int)DateTime.Today.DayOfWeek);
                var thisWeekStart = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + 1);
                return (x) => x.Date <= thisWeekEnd && x.Date >= thisWeekStart;
            }
        }
    }
}