using MBSTU.OnlineCourse.Data.Class;
using MBSTU.OnlineCourse.Data.Interface;
using MBSTU.OnlineCourse.Framework.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MBSTU.OnlineCourse.Framework.Class
{
    public class RegistrationUnitOfWork : UnitOfWork<FrameworkContext> ,IRegistrationUnitOfWork
    {
        public IStudentRepository StudentRepository { get; set; }
        public ICourseRepository CourseRepository { get; set; }
        public IStudentRegistrationRepository StudentRegistrationRepository { set; get; }
        public RegistrationUnitOfWork(string connectionString, string migrationAssemblyName)
            : base(connectionString, migrationAssemblyName)
        {
            StudentRepository = new StudentRepository(_dbContext);
            CourseRepository = new CourseRepository(_dbContext);
            StudentRegistrationRepository = new StudentRegistrationRepository(_dbContext);
        }
    }
}
