using CourseRegistrationSystem.Data;
using CourseRegistrationSystem.Framework.Entities;
using CourseRegistrationSystem.Framework.Unitofwork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistrationSystem.Framework.Services
{
    public class StudentRegistrationService : IStudentRegistrationService
    {
        private IRegistrationUnitOfWork _resultUnitOfWork;
        public StudentRegistrationService(IRegistrationUnitOfWork resultUnitOfWork)
        {
            _resultUnitOfWork = resultUnitOfWork;
        }

        public void CreateStudentRegistration(StudentRegistration newstudentRegistration)
        {
            _resultUnitOfWork.StudentRegistrationRepository.Add(newstudentRegistration);
            _resultUnitOfWork.Save();
        }
        public void EditStudentRegistration(StudentRegistration studentRegistration)
        {
            var exitStudentRegistration = _resultUnitOfWork.StudentRegistrationRepository.GetById(studentRegistration.Id);
            exitStudentRegistration.StudentId = studentRegistration.StudentId;
            exitStudentRegistration.CourseId = studentRegistration.CourseId;
            exitStudentRegistration.EnrollDate = studentRegistration.EnrollDate;
            exitStudentRegistration.IsPaymentComplete = studentRegistration.IsPaymentComplete;
           
            _resultUnitOfWork.StudentRegistrationRepository.Edit(exitStudentRegistration);
            _resultUnitOfWork.Save();


        }

        public void DeleteStudentRegistration(int id)
        {
            _resultUnitOfWork.StudentRegistrationRepository.Remove(id);
            _resultUnitOfWork.Save();
        }

        public void Dispose()
        {
            _resultUnitOfWork.Dispose();
        }

        public StudentRegistration GetStudentRegistrationbyId(int id)
        {
            return _resultUnitOfWork.StudentRegistrationRepository.GetById(id);

        }
        public async Task<(IList<StudentRegistration> Items, int Total, int TotalDisplay)> GetAllAsync(
            string searchText, string orderBy, int pageIndex, int pageSize)
        {
            var columnsMap = new Dictionary<string, Expression<Func<StudentRegistration, object>>>()
            {
                ["enrollDate"] = v => v.EnrollDate,
                ["studentName"] = v => v.Student.Name,
                ["courseTitle"] = v => v.Course.Title,
            };

            var result = await _resultUnitOfWork.StudentRegistrationRepository.GetAsync<StudentRegistration>(
                x => x, x => x.Student.Name.Contains(searchText) || x.Course.Title.Contains(searchText),
                x => x.ApplyOrdering(columnsMap, orderBy),
                x => x.Include(y => y.Student).Include(y => y.Course),
                pageIndex, pageSize, true);

            return (result.Items, result.Total, result.TotalDisplay);
        }
        public async Task<IList<object>> GetStudentsForSelectAsync()
        {
            return await _resultUnitOfWork.StudentRepository.GetAsync<object>(x => new { Value = x.Id.ToString(), Text = x.Name }, null, null, null, true);
        }

        public async Task<IList<object>> GetCoursesForSelectAsync()
        {
            return await _resultUnitOfWork.CourseRepository.GetAsync<object>(x => new { Value = x.Id.ToString(), Text = x.Title }, null, null, null, true);
        }

    }  
}
