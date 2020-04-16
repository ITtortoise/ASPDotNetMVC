using MBSTU.OnlineCourse.Data.Model;
using MBSTU.OnlineCourse.Framework.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MBSTU.OnlineCourse.Framework.Model
{
    public class OnlineCourseUnitOfWork : UnitOfWork<FrameworkContext>, IOnlineCourseUnitOfWork
    {
        public IStudentRepository CourseRepositroy { get; set; }
        public OnlineCourseUnitOfWork(string connectionString, string migrationAssemblyName)
            : base(connectionString, migrationAssemblyName)
        {
            CourseRepositroy = new StudentRepository(_dbContext);
        }
    }
}
