using GradeSystem.Data;
using GradeSystem.Framework.ContextModule;
using GradeSystem.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeSystem.Framework.RepositoryFile
{
    public class GradeRepository : Repository<Grade,int,FrameworkContext>,IGradeRepository
    {
        public GradeRepository(FrameworkContext dbContext) : base(dbContext)
        {

        }
    }
}
