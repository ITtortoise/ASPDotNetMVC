using CourseRegistrationSystem.Data;
using CourseRegistrationSystem.Framework.FrameworkContextFiles;
using CourseRegistrationSystem.Framework.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseRegistrationSystem.Framework.Unitofwork
{
    public class RegistrationUnitOfWork : UnitOfWork, IRegistrationUnitOfWork
    {
        public IStudentRepository StudentRepository { get; set; }
        public ICourseRepository CourseRepository { get; set; }
        public IStudentRegistrationRepository StudentRegistrationRepository { get; set; }
       
        public RegistrationUnitOfWork(FrameworkContext dbContext,IStudentRepository studentRepository, ICourseRepository courseRepository,IStudentRegistrationRepository studentRegistrationRepository)
            : base(dbContext)
        {
            StudentRepository = studentRepository;
            CourseRepository = courseRepository;
            StudentRegistrationRepository = studentRegistrationRepository;
        }
    }
}
