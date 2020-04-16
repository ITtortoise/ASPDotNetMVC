using MBSTU.OnlineCourse.Framework.Interface;
using MBSTU.OnlineCourse.Framwork.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MBSTU.OnlineCourse.Framework.Model
{
    public class StudentService : IStudentService
    {
        private IOnlineCourseUnitOfWork _OnlineCourseUnitOfWork;

        public StudentService(IOnlineCourseUnitOfWork OnlineCourseUnitOfWork)
        {
            _OnlineCourseUnitOfWork = OnlineCourseUnitOfWork;
        }

        public (IList<Student> records, int total, int totalDisplay) GetStudents(int pageIndex, int pageSize, string searchText, string sortText)
        {
            throw new NotImplementedException();
        }
    }
}
