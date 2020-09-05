using CourseRegistrationSystem.Framework.Entities;
using CourseRegistrationSystem.Framework.MenuSessionExceptionFiles;
using CourseRegistrationSystem.Framework.Unitofwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseRegistrationSystem.Framework.Services
{
    public class CourseService : ICourseService
    {
        private IRegistrationUnitOfWork _libraryUnitOfWork;

        public CourseService(IRegistrationUnitOfWork libraryUnitOfWork)
        {
            _libraryUnitOfWork = libraryUnitOfWork;
        }
        public void CreateCourse(Course course)
        {
            var count = _libraryUnitOfWork.CourseRepository.GetCount(x => x.Title == course.Title);
            if (count > 0)
                throw new DuplicationException("Course title already exists", nameof(course.Title));
            _libraryUnitOfWork.CourseRepository.Add(course);
            _libraryUnitOfWork.Save();
        }

        public void EditCourse(Course course)
        {
            var count = _libraryUnitOfWork.CourseRepository.GetCount(x => x.Title == course.Title
                    && x.Id != course.Id);

            if (count > 0)
                throw new DuplicationException("Course title already exists", nameof(course.Title));

            var existingCourse = _libraryUnitOfWork.CourseRepository.GetById(course.Id);
            existingCourse.Title = course.Title;
            existingCourse.SeatCount = course.SeatCount;
            existingCourse.Fee = course.Fee;

            _libraryUnitOfWork.Save();
        }

        public Course GetCourseById(int id)
        {
            return _libraryUnitOfWork.CourseRepository.GetById(id);
        }

        public void Dispose()
        {
            _libraryUnitOfWork?.Dispose();
        }


        public (IList<Course> records, int total, int totalDisplay) GetCourses(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result = _libraryUnitOfWork.CourseRepository.GetAll().ToList();
            return (result, 0, 0);
        }

        public void DeleteCourse(int id)
        {
            _libraryUnitOfWork.CourseRepository.Remove(id);
            _libraryUnitOfWork.Save();
        }

        public IList<Course> GetAllCourse()
        {
            return _libraryUnitOfWork.CourseRepository.GetAll();
        }
    }
}