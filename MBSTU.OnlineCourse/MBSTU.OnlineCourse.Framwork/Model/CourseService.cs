using MBSTU.OnlineCourse.Framework.Interface;
using MBSTU.OnlineCourse.Framwork.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MBSTU.OnlineCourse.Framework.Model
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
