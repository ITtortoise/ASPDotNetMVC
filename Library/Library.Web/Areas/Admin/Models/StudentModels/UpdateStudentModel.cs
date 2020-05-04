using Library.Framework.Entity;
using Library.Framework.StudentServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Web.Areas.Admin.Models.StudentModels
{
    public class UpdateStudentModel : StudentBaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Session { get; set; }

        public UpdateStudentModel(IStudentService studentService) : base(studentService) { }
        public UpdateStudentModel() : base() { }

        public void Modify()
        {
            var newstudent = new Student
            {
                Id = this.Id,
                Name = this.Name,
                Department = this.Department,
                Session = this.Session
            };

            var updatestudent = _studentService.GetStudentsById(Id);
            updatestudent.Name = newstudent.Name;
            updatestudent.Department = newstudent.Department;
            updatestudent.Session = newstudent.Session;
            _studentService.updateStudent(updatestudent);
           
        }
    }
}
