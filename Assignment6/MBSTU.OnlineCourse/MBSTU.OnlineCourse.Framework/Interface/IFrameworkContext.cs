using MBSTU.OnlineCourse.Framework.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MBSTU.OnlineCourse.Framework.Interface
{
    public interface IFrameworkContext
    {
        DbSet<Student> Students { get; set; }
        DbSet<Course> Courses { get; set; }
    }
}
