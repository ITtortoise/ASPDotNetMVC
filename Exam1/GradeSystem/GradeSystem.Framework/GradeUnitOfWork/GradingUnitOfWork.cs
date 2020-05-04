using GradeSystem.Data;
using GradeSystem.Framework.ContexModule;
using GradeSystem.Framework.StudentAll;
using GradeSystem.Framework.SubjectAll;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeSystem.Framework.GradeUnitOfWork
{
    public class GradingUnitOfWork : UnitOfWork, IGradingUnitOfWork
    {
        public IStudentRepository StudentRepository { get; set; }
        public ISubjectRepository SubjectRepository { get; set; }
       
        public GradingUnitOfWork(FrameworkContext context,  IStudentRepository studentRepository, ISubjectRepository subjectRepository)
            : base(context)
        {
            StudentRepository = studentRepository;
            SubjectRepository = subjectRepository;
           
        }
    }
}
