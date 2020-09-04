using CourseRegistrationSystem.Data;
using CourseRegistrationSystem.Framework.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseRegistrationSystem.Framework.Unitofwork
{
    public interface IRegistrationUnitOfWork : IUnitOfWork
    {
        IStudentRepository StudentRepository { get; set; }
        ICourseRepository CourseRepository { get; set; }
        IStudentRegistrationRepository StudentRegistrationRepository { get; set; }
    }
}
