using MBSTU.OnlineCourse.Data.Model;
using MBSTU.OnlineCourse.Framework.Interface;
using MBSTU.OnlineCourse.Framwork.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MBSTU.OnlineCourse.Framework.Model
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
