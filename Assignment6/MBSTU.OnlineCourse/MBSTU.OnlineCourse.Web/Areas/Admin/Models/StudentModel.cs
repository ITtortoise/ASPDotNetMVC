using Autofac;
using MBSTU.OnlineCourse.Framework.Entity;
using MBSTU.OnlineCourse.Framework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MBSTU.OnlineCourse.Web.Areas.Admin.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public void StudentGetById(int id)
        {
            var service = Startup.AutofacContainer.Resolve<IStudentService>();
            service.StudentInfo(id);
        }

        public void NewStudent()
        {
            var student = new Student
            {
                Name = this.Name,
                DateOfBirth = this.DateOfBirth
            };
            var service = Startup.AutofacContainer.Resolve<IStudentService>();
            service.AddNewStudent(student);
        }
        public void UpdateStudent(Student student)
        {

            var service = Startup.AutofacContainer.Resolve<IStudentService>();
            service.UpDateStudentInfo(student);

        }

       

        public void DeleteStudent()
        {
            var Id = this.Id;
            var service = Startup.AutofacContainer.Resolve<IStudentService>();
            service.DeleteStudentInfo(Id);
        }
    }
}
