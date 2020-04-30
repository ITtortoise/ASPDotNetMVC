using Library.Data.BaseRepository;
using Library.Framework.ContextModule;
using Library.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Framework.StudentRepositories
{
    public class StudentRepository : Repository<Student, int, FrameworkContext>, IStudentRepository
    {
        public StudentRepository(FrameworkContext dbContext)
            : base(dbContext)
        {

        }


    }
}
