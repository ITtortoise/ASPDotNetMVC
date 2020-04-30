using Autofac;
using Library.Framework.BookServices;
using Library.Framework.StudentServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Web.Areas.Admin.Models.StudentModels
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
