using Autofac;
using CourseRegistrationSystem.Framework.MenuSessionExceptionFiles;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseRegistrationSystem.Web.Areas.Admin.Models
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
                            Title = "Course Information",
                            Childs = new List<MenuChildItem>
                            {
                                new MenuChildItem{ Title = "View Courses", Url = "/Admin/Courses" },
                                new MenuChildItem{ Title = "Add Course", Url ="/Admin/Courses/AddCourses"}
                            },
                            Title2 = "Student Information",
                            Childs2 = new List<MenuChildItem>
                            {
                                new MenuChildItem{ Title = "View Students", Url = "/Admin/Students" },
                                new MenuChildItem{ Title = "Add Student", Url ="/Admin/Students/AddStudent"}
                            },
                            Title3 = "Student Registration Information",
                            Childs3 = new List<MenuChildItem>
                            {
                                new MenuChildItem{ Title = "View Records", Url = "/Admin/Registrations" },
                                new MenuChildItem{ Title = "Add Record", Url ="/Admin/Registrations/AddRegistration"}
                            }
                        }
                    }
                }
            };
        }
    }
}
