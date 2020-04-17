using MBSTU.OnlineCourse.Framework.Entity;
using MBSTU.OnlineCourse.Framework.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MBSTU.OnlineCourse.Framework.Class
{
    public class CourseService : ICourseService
    {
        private IOnlineCourseUnitOfWork _OnlineCourseUnitOfWork;

        public CourseService(IOnlineCourseUnitOfWork OnlineCourseUnitOfWork)
        {
            _OnlineCourseUnitOfWork = OnlineCourseUnitOfWork;
        }

        public (IList<Course> records, int total, int totalDisplay) GetCourses(int pageIndex, int pageSize, string searchText, string sortText)
        {
            throw new NotImplementedException();
        }
    }
}
