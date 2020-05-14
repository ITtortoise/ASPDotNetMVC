using GradeSystem.Data;
using GradeSystem.Framework.ContextModule;
using GradeSystem.Framework.RepositoryFile;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeSystem.Framework.UnitOfWorkFile
{
    public class ResultUnitOfWork : UnitOfWork, IResultUnitOfWork
    {
        public IStudentRepository StudentRepository { get ; set; }
        public ISubjectRepository SubjectRepository { get ; set ; }
        public IGradeRepository GradeRepository { get ; set ; }
        public ResultUnitOfWork(FrameworkContext context,IStudentRepository studentRepository,ISubjectRepository subjectRepository,IGradeRepository gradeRepository) : base(context)
        {
            StudentRepository = studentRepository;
            SubjectRepository = subjectRepository;
            GradeRepository = gradeRepository;
        }
    }
}
