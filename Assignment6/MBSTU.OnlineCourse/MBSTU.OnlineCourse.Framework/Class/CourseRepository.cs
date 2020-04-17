using MBSTU.OnlineCourse.Data.Class;
using MBSTU.OnlineCourse.Framework.Entity;
using MBSTU.OnlineCourse.Framework.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MBSTU.OnlineCourse.Framework.Class
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(DbContext dbContext)
            : base(dbContext)
        {

        }

        public IList<Course> GetNewCourses()
        {
            throw new NotImplementedException();
        }
    }
}
