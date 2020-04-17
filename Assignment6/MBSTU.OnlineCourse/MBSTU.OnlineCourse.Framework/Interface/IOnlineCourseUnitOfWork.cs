﻿using MBSTU.OnlineCourse.Data.Interface;
using MBSTU.OnlineCourse.Framework.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace MBSTU.OnlineCourse.Framework.Interface
{
    public interface IOnlineCourseUnitOfWork : IUnitOfWork<FrameworkContext>
    {
        IStudentRepository StudentRepositroy { get; set; }
        ICourseRepository CourseRepository { get; set; }
    }
}
