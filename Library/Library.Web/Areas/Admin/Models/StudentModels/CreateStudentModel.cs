using Library.Framework.BookServices;
using Library.Framework.Entity;
using Library.Framework.StudentServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Web.Areas.Admin.Models.StudentModels
{
    public class CreateStudentModel : StudentBaseModel
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Session { get; set; }

        public CreateStudentModel(IStudentService studentService) : base(studentService) { }
        public CreateStudentModel() : base() { }

        public void Create()
        {
            var student = new Student
            {
                Name = this.Name,
                Department = this.Department,
                Session = this.Session,
              
            };

            _studentService.CreateStudent(student);
        }

        
    }
}
