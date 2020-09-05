using CourseRegistrationSystem.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseRegistrationSystem.Framework.Services
{
    public interface ICourseService : IDisposable
    {
        (IList<Course> records, int total, int totalDisplay) GetCourses(int pageIndex,
                                                                    int pageSize,
                                                                    string searchText,
                                                                    string sortText);
        void CreateCourse(Course course);
        void EditCourse(Course course);
        Course GetCourseById(int id);
        void DeleteCourse(int id);
        IList<Course> GetAllCourse();
    }
}
