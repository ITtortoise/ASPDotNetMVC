using CourseRegistrationSystem.Data;
using CourseRegistrationSystem.Framework.Entities;
using CourseRegistrationSystem.Framework.FrameworkContextFiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseRegistrationSystem.Framework.Repositories
{
    public class StudentRegistrationRepository : Repository<StudentRegistration, int, FrameworkContext> , IStudentRegistrationRepository
    {
        public StudentRegistrationRepository (FrameworkContext dbContext): base(dbContext)
        {

        }
    }
}
