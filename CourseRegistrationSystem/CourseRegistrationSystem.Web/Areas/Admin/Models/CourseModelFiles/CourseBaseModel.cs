using Autofac;
using CourseRegistrationSystem.Framework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationSystem.Web.Areas.Admin.Models.CourseModelFiles
{
    public class CourseBaseModel : AdminBaseModel, IDisposable
    {
        protected readonly ICourseService _courseService;
        public CourseBaseModel(ICourseService courseService)
        {
            _courseService = courseService;
        }
        public CourseBaseModel()
        {
            _courseService = Startup.AutofacContainer.Resolve<ICourseService>();
        }
        public void Dispose()
        {
            _courseService?.Dispose();
        }
    }
}
