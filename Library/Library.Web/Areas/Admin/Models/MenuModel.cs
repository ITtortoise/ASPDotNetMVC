using Library.Framework.MenuFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Web.Areas.Admin.Models
{
    public class MenuModel
    {
       public IList<MenuItem> MenuItems { get; set; }
    }
}
