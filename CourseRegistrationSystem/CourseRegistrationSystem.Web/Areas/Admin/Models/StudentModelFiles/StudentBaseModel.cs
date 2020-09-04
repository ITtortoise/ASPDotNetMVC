using Autofac;
using CourseRegistrationSystem.Framework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationSystem.Web.Areas.Admin.Models.StudentModelFiles
{
    public class StudentBaseModel : AdminBaseModel, IDisposable
    {
        protected readonly IStudentService _studentService;
        public StudentBaseModel(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public StudentBaseModel()
        {
            _studentService = Startup.AutofacContainer.Resolve<IStudentService>();
        }
        public void Dispose()
        {
            _studentService?.Dispose();
        }
    }
}
