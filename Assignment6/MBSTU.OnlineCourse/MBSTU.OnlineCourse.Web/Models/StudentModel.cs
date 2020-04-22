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
        

        public void NewStudent()
        {
          
        }
        public void UpdateStudent(Student student)
        {
            
            var service = Startup.AutofacContainer.Resolve<IStudentService>();
            service.UpDateStudentInfo(student);

        }

        public void StudentGetById(int id)
        {
            var service = Startup.AutofacContainer.Resolve<IStudentService>();
            service.StudentInfo(id);
        }

        public void DeleteStudent(int id)
        {
           
        }
    }
}
