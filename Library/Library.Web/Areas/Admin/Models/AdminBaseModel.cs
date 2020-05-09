
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
                        Title = "Books Information",
                        Childs = new List<MenuChildItem>
                        {
                            new MenuChildItem{Title = "View Books List",Url="/Admin/Books/Index"},
                            new MenuChildItem{Title = "Add Book Information",Url="/Admin/Books/AddBook"},
                            new MenuChildItem{Title = "Delete Book Information",Url="/Admin/DeleteBook"},
                            new MenuChildItem{Title = "Update Book's Information",Url="/Admin/Books/UpdateBook"}
                        }
                    }
                }
            }
            };
        }
    }
}
