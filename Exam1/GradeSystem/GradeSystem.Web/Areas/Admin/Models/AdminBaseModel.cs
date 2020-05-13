using Autofac;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GradeSystem.Framework.ResponseFile;
using GradeSystem.Framework.MenuFile;

namespace GradeSystem.Web.Areas.Admin.Models
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
                            
                            Title = "Students Information",
                            Childs = new List<MenuChildItem>
                            {
                                new MenuChildItem{ Title = "View Students", Url = "/Admin/Students" },
                                new MenuChildItem{ Title = "Add Student", Url ="/Admin/Students/AddStudent"}
                            },
                            Title2 = "Subjects Information",
                            Childs2 = new List<MenuChildItem>
                            {
                                new MenuChildItem{ Title = "View Subjects", Url = "/Admin/Subjects" },
                                new MenuChildItem{ Title = "Add Subject", Url ="/Admin/Subjects/AddSubject"}
                            },
                            Title3 = "Result",
                            Childs3 = new List<MenuChildItem>
                            {
                                new MenuChildItem{ Title = "View Results", Url = "/Admin/Grades" },
                                new MenuChildItem{ Title = "Add Result", Url ="/Admin/Grades/AddGrade"}
                            },
                        }
                    }
                }
            };
        }
    }
}
