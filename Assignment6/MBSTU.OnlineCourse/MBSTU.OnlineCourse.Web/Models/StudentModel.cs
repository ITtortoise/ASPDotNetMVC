using Autofac;
using MBSTU.OnlineCourse.Framework.Entity;
using MBSTU.OnlineCourse.Framework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MBSTU.OnlineCourse.Web.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

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
    }
}
