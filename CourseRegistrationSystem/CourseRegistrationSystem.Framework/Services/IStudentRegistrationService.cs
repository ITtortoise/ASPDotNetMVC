using CourseRegistrationSystem.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistrationSystem.Framework.Services
{
    public interface IStudentRegistrationService : IDisposable
    {
        Task<(IList<StudentRegistration> Items, int Total, int TotalDisplay)> GetAllAsync(
            string searchText, string orderBy, int pageIndex, int pageSize);
        void CreateStudentRegistration(StudentRegistration newstudentRegistration);
        void DeleteStudentRegistration(int id);
        StudentRegistration GetStudentRegistrationbyId(int id);
        void EditStudentRegistration(StudentRegistration studentRegistration);
        Task<IList<object>> GetStudentsForSelectAsync();
        Task<IList<object>> GetCoursesForSelectAsync();
    }
}
