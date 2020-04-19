using MBSTU.OnlineCourse.Framework.Entity;
using MBSTU.OnlineCourse.Framework.Interface;
using System;

namespace MBSTU.OnlineCourse.Framework.Class
{
    public class CourseService : ICourseService
    {
        private IRegistrationUnitOfWork _registrationUnitOfWork;

        public CourseService(IRegistrationUnitOfWork registrationUnitOfWork)
        {
            _registrationUnitOfWork = registrationUnitOfWork;
        }

        public void AddNewCourse(Course course)
        {
            _registrationUnitOfWork.CourseRepository.Add(course);
            _registrationUnitOfWork.Save();
        }

        public void UpDateCourseInfo(Course course)
        {

        }

    }
}
