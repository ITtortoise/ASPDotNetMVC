using Autofac;
using CourseRegistrationSystem.Framework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationSystem.Web.Areas.Admin.Models.StudentRegistrationModelFiles
{
    public class StudentRegistrationBaseModel : AdminBaseModel, IDisposable
    {
        protected readonly IStudentRegistrationService _studentRegistrationService;
        public StudentRegistrationBaseModel(IStudentRegistrationService studentRegistrationService)
        {
            _studentRegistrationService = studentRegistrationService;
        }
        public StudentRegistrationBaseModel()
        {
            _studentRegistrationService = Startup.AutofacContainer.Resolve<IStudentRegistrationService>();
        }
        public void Dispose()
        {
            _studentRegistrationService?.Dispose();
        }
    }
}
