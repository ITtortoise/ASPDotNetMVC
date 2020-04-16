using MBSTU.OnlineCourse.Data.Interface;
using MBSTU.OnlineCourse.Framwork.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MBSTU.OnlineCourse.Framework.Interface
{
    public interface ICourseRepository : IRepository<Course>
    {
        IList<Course> GetNewCourses();
    }
}
