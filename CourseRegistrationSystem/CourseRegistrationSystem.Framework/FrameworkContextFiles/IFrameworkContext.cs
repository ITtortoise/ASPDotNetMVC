using CourseRegistrationSystem.Framework.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseRegistrationSystem.Framework.FrameworkContextFiles
{
    public interface IFrameworkContext
    {
        DbSet<Student> Students { get; set; }
        DbSet<Course> Courses { get; set; }
    }
}
