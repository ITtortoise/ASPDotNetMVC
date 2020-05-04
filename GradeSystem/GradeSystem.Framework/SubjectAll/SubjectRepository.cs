using GradeSystem.Data;
using GradeSystem.Framework.ContexModule;
using GradeSystem.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeSystem.Framework.SubjectAll
{
    public class SubjectRepository : Repository<Subject, int, FrameworkContext>, ISubjectRepository
    {
        public SubjectRepository(FrameworkContext dbContext)
            : base(dbContext)
        {

        }


    }
}
