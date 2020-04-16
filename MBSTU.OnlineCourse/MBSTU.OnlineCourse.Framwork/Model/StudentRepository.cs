using MBSTU.OnlineCourse.Data.Model;
using MBSTU.OnlineCourse.Framework.Interface;
using MBSTU.OnlineCourse.Framwork.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MBSTU.OnlineCourse.Framework.Model
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(DbContext dbContext)
            : base(dbContext)
        {

        }

        public IList<Student> GetNewStudents()
        {
            throw new NotImplementedException();
        }
    }
}
