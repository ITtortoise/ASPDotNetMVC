using MBSTU.OnlineCourse.Data.Class;
using MBSTU.OnlineCourse.Framework.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MBSTU.OnlineCourse.Framework.Class
{
    public class RegistrationUnitOfWork : UnitOfWork<FrameworkContext>, IRegistrationUnitOfWork
    {
        public IStudentRepository StudentRepositroy { get; set; }
        public ICourseRepository CourseRepository { get; set; }
        public RegistrationUnitOfWork(string connectionString, string migrationAssemblyName)
            : base(connectionString, migrationAssemblyName)
        {
            StudentRepositroy = new StudentRepository(_dbContext);
            CourseRepository = new CourseRepository(_dbContext);
        }
    }
}
