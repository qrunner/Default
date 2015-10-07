using System;
using System.Linq.Expressions;

namespace Invoice.App.ViewModels.Filters
{
    class PrevWeek : FilterViewModel
    {
        public PrevWeek() : base("На прошлой неделе") { }

        public override Expression<Func<Model.Invoice, bool>> FilterExpression
        {
            get
            {
                var prevWeekEnd = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
                var prevWeekStart = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek - 6);
                return (x) => x.Date <= prevWeekEnd && x.Date >= prevWeekStart;
            }
        }
    }
}