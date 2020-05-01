using GradeSystem.Data;
using GradeSystem.Framework.StudentAll;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeSystem.Framework.GradeUnitOfWork
{
    public interface IGradingUnitOfWork : IUnitOfWork
    {
        IStudentRepository StudentRepositroy { get; set; }
        ISubjectRepository SubjectRepositroy { get; set; }
       
    }
}
