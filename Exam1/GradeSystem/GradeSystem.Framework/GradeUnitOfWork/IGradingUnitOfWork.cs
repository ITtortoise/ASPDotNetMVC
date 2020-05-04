using GradeSystem.Data;
using GradeSystem.Framework.StudentAll;
using GradeSystem.Framework.SubjectAll;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeSystem.Framework.GradeUnitOfWork
{
    public interface IGradingUnitOfWork : IUnitOfWork
    {
        IStudentRepository StudentRepository { get; set; }
        ISubjectRepository SubjectRepository { get; set; }

    }
}
