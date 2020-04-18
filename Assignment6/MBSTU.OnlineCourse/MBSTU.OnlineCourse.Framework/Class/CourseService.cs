using MBSTU.OnlineCourse.Framework.Entity;
using MBSTU.OnlineCourse.Framework.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MBSTU.OnlineCourse.Framework.Class
{
    public class CourseService : ICourseService
    {
        private IRegistrationUnitOfWork _OnlineCourseUnitOfWork;

        public CourseService(IRegistrationUnitOfWork OnlineCourseUnitOfWork)
        {
            _OnlineCourseUnitOfWork = OnlineCourseUnitOfWork;
        }

        
    }
}
