using Library.Data.BaseRepository;
using Library.Framework.ContextModule;
using Library.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Framework.StudentRegistrationRepositories
{
    public class StudentRegistrationRepository : Repository<StudentRegistration, int, FrameworkContext>, IStudentRegistrationRepository
    {
        public StudentRegistrationRepository(FrameworkContext dbContext)
            : base(dbContext)
        {

        }
    }
}
