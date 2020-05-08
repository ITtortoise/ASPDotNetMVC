
using Library.Framework.MenuFiles;
using Library.Web.Areas.Admin.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Web.Areas.Admin.Models
{
    public abstract class AdminBaseModel
    {
        public MenuModel MenuModel { get; set; }

        public AdminBaseModel()
        {
            MenuModel = new MenuModel
            {
                MenuItems = new List<MenuItem>
            {
                {
                    new MenuItem
                    {
                        Title = "Books",
                        Childs = new List<MenuChildItem>
                        {
                            new MenuChildItem{Title = "View Books",Url="/Admin/Books"},
                            new MenuChildItem{Title = "Add Book",Url="/Admin/Books/AddBook"}
                        }
                    }
                }
            }
            };
        }
    }
}
