using System;
using Mcs.Model;
using Mcs.Services;
using Mcs.WebExtensions;

namespace Mcs.Server.Controllers
{
    public class DishController : EditController<Dish, IDishService>
    {
        protected override void AfterCreate(Dish item)
        {
            base.AfterCreate(item);
            item.MenuCategoryId = SelectedCategoryId;
        }

        private int SelectedCategoryId
        {
            get
            {
                return Convert.ToInt32(Request.QueryString["catid"]);
            }
        }       
    }
}