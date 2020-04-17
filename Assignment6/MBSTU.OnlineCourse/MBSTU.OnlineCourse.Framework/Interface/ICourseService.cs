using MBSTU.OnlineCourse.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MBSTU.OnlineCourse.Framework.Interface
{
    public interface ICourseService
    {
        (IList<Course> records, int total, int totalDisplay) GetCourses(int pageIndex,
                                                                   int pageSize,
                                                                   string searchText,
                                                                   string sortText);
    }
}
