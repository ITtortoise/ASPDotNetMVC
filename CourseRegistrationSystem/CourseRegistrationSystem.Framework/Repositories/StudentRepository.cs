using CourseRegistrationSystem.Data;
using CourseRegistrationSystem.Framework.Entities;
using CourseRegistrationSystem.Framework.FrameworkContextFiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseRegistrationSystem.Framework.Repositories
{
    public class StudentRepository : Repository<Student,int,FrameworkContext> ,IStudentRepository
    {
        public StudentRepository (FrameworkContext dbContext) : base(dbContext)
        {

        }
    }
}
