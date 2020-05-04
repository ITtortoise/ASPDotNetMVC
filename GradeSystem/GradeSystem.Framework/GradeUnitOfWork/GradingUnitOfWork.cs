using GradeSystem.Data;
using GradeSystem.Framework.ContexModule;
using GradeSystem.Framework.StudentAll;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeSystem.Framework.GradeUnitOfWork
{
    public class GradingUnitOfWork : UnitOfWork, IGradingUnitOfWork
    {
        public IStudentRepository StudentRepositroy { get; set; }
        public ISubjectRepository SubjectRepositroy { get; set; }
       
        public GradingUnitOfWork(FrameworkContext context,  IStudentRepository studentRepository)
            : base(context)
        {
            StudentRepositroy = studentRepository;
            SubjectRepositroy = subjectRepositroy;
           
        }
    }
}
