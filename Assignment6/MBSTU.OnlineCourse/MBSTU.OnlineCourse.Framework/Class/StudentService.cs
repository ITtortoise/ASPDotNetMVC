using MBSTU.OnlineCourse.Framework.Entity;
using MBSTU.OnlineCourse.Framework.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MBSTU.OnlineCourse.Framework.Class
{
    public class StudentService : IStudentService
    {
        private IRegistrationUnitOfWork _OnlineCourseUnitOfWork;

        public StudentService(IRegistrationUnitOfWork OnlineCourseUnitOfWork)
        {
            _OnlineCourseUnitOfWork = OnlineCourseUnitOfWork;
        }

        public (IList<Student> records, int total, int totalDisplay) GetStudents(int pageIndex, int pageSize, string searchText, string sortText)
        {
            throw new NotImplementedException();
        }
    }
}
