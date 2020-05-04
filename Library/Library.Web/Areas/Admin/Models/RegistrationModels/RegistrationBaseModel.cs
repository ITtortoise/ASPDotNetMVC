using Autofac;
using Library.Framework.StudentRegistrationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Web.Areas.Admin.Models.RegistrationModels
{
    public class RegistrationBaseModel : AdminBaseModel,IDisposable
    {
        protected readonly IStudentRegistrationService _registrationService;
        public RegistrationBaseModel(IStudentRegistrationService registrationService)
        {
            _registrationService = registrationService;
        }

        public RegistrationBaseModel()
        {
            _registrationService = Startup.AutofacContainer.Resolve<IStudentRegistrationService>();
        }

        public void Dispose()
        {
            _registrationService?.Dispose();
        }
    }
}
