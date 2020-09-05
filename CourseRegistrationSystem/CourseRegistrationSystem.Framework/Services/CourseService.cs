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
        private IRegistrationUnitOfWork _resultUnitOfWork;

        public CourseService(IRegistrationUnitOfWork libraryUnitOfWork)
        {
            _resultUnitOfWork = libraryUnitOfWork;
        }
        public void CreateCourse(Course course)
        {
            var count = _resultUnitOfWork.CourseRepository.GetCount(x => x.Title == course.Title);
            if (count > 0)
                throw new DuplicationException("Course title already exists", nameof(course.Title));
            _resultUnitOfWork.CourseRepository.Add(course);
            _resultUnitOfWork.Save();
        }

        public void EditCourse(Course course)
        {
            var count = _resultUnitOfWork.CourseRepository.GetCount(x => x.Title == course.Title
                    && x.Id != course.Id);

            if (count > 0)
                throw new DuplicationException("Course title already exists", nameof(course.Title));

            var existingCourse = _resultUnitOfWork.CourseRepository.GetById(course.Id);
            existingCourse.Title = course.Title;
            existingCourse.SeatCount = course.SeatCount;
            existingCourse.Fee = course.Fee;

            _resultUnitOfWork.Save();
        }

        public Course GetCourseById(int id)
        {
            return _resultUnitOfWork.CourseRepository.GetById(id);
        }

        public void Dispose()
        {
            _resultUnitOfWork?.Dispose();
        }


        public (IList<Course> records, int total, int totalDisplay) GetCourses(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result = _resultUnitOfWork.CourseRepository.GetAll().ToList();
            return (result, 0, 0);
        }

        public void DeleteCourse(int id)
        {
            _resultUnitOfWork.CourseRepository.Remove(id);
            _resultUnitOfWork.Save();
        }

        public IList<Course> GetAllCourse()
        {
            return _resultUnitOfWork.CourseRepository.GetAll();
        }
    }
}