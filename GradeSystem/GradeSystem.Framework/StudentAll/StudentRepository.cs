using GradeSystem.Data;
using GradeSystem.Framework.ContexModule;
using GradeSystem.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeSystem.Framework.StudentAll
{
    public class StudentRepository : Repository<Student, int, FrameworkContext>, IStudentRepository
    {
        public StudentRepository(FrameworkContext dbContext)
            : base(dbContext)
        {

        }


    }
}
