using GradeSystem.Data;
using GradeSystem.Framework.ContextModule;
using GradeSystem.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeSystem.Framework.RepositoryFile
{
    public class StudentRepository : Repository<Student,int,FrameworkContext>,IStudentRepository
    {
        public StudentRepository(FrameworkContext dbContext) : base(dbContext)
        {

        }
    }
}
