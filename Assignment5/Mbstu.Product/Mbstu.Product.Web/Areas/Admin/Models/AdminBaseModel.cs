using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mbstu.Product.Web.Areas.Admin.Models
{
    public class AdminBaseModel
    {
        public MenuModel MenuModel { get; set; }
        public AdminBaseModel()
        {
            MenuModel = new MenuModel();
        }
    }
}
