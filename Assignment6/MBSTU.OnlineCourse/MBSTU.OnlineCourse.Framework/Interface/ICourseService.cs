using MBSTU.OnlineCourse.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MBSTU.OnlineCourse.Framework.Interface
{
    public interface ICourseService
    {
        void AddNewCourse(Course course);
        void UpDateCourseInfo(Course course);
    }
}
