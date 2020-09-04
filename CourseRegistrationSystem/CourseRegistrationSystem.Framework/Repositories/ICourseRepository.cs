﻿using CourseRegistrationSystem.Data;
using CourseRegistrationSystem.Framework.Entities;
using CourseRegistrationSystem.Framework.FrameworkContextFiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseRegistrationSystem.Framework.Repositories
{
    public interface ICourseRepository : IRepository<Course, int, FrameworkContext>
    {
    }
}
