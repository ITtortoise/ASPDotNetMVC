using MBSTU.OnlineCourse.Data.Interface;
using MBSTU.OnlineCourse.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MBSTU.OnlineCourse.Framework.Interface
{
    public interface IStudentRepository : IRepository<Student>
    {
        IList<Student> GetNewStudents();
    }
}
