using Library.Framework.StudentRegistrationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Web.Areas.Admin.Models.RegistrationModels
{
    public class RegistrationModel : RegistrationBaseModel
    {
        public RegistrationModel(IStudentRegistrationService registrationService) : base(registrationService) { }
        public RegistrationModel() : base() { }

    }
}
