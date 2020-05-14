using GradeSystem.Data;
using GradeSystem.Framework.RepositoryFile;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeSystem.Framework.UnitOfWorkFile
{
    public interface IResultUnitOfWork : IUnitOfWork
    {
        IStudentRepository StudentRepository { get; set; }
        ISubjectRepository SubjectRepository { get; set; }
        IGradeRepository GradeRepository { get; set; }
    }
}
