
using Autofac;
using Library.Framework.MenuFiles;
using Library.Web.Areas.Admin.Controllers;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Framework;
namespace Library.Web.Areas.Admin.Models
{
    public abstract class AdminBaseModel
    {
        public MenuModel MenuModel { get; set; }
        public ResponseModel Response
        {
            get
            {
                if (_httpContextAccessor.HttpContext.Session.IsAvailable
                    && _httpContextAccessor.HttpContext.Session.Keys.Contains(nameof(Response)))
                {
                    var response = _httpContextAccessor.HttpContext.Session.Get<ResponseModel>(nameof(Response));
                    _httpContextAccessor.HttpContext.Session.Remove(nameof(Response));

                    return response;
                }
                else
                    return null;
            }
            set
            {
                _httpContextAccessor.HttpContext.Session.Set(nameof(Response),
                    value);
            }
        }

        protected IHttpContextAccessor _httpContextAccessor;
        public AdminBaseModel(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            SetupMenu();
        }

        public AdminBaseModel()
        {
            _httpContextAccessor = Startup.AutofacContainer.Resolve<IHttpContextAccessor>();
            SetupMenu();
        }

        private void SetupMenu()
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
                                new MenuChildItem{ Title = "View Books", Url = "/Admin/Books" },
                                new MenuChildItem{ Title = "Add Book", Url ="/Admin/Books/AddBook"}
                            },
                            Title2 = "Students Information",
                            Childs2 = new List<MenuChildItem>
                            {
                                new MenuChildItem{ Title = "View Students", Url = "/Admin/Students" },
                                new MenuChildItem{ Title = "Add Student", Url ="/Admin/Students/AddStudent"}
                            }
                        }
                    }
                }
            };
        }
    }
}
