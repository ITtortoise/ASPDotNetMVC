using MBSTU.OnlineCourse.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MBSTU.OnlineCourse.Framework.Interface
{
    public interface IStudentService
    {
         void AddNewStudent(Student student);
         void UpDateStudentInfo(Student student);
         void DeleteStudentInfo(int id);
         void StudentInfo(int id);
    }
}

