using CourseRegistrationSystem.Framework.Entities;
using CourseRegistrationSystem.Framework.Unitofwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public (IList<StudentRegistration> records, int total, int totalDisplay) GetStudentRegistrations(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result = _resultUnitOfWork.StudentRegistrationRepository.GetAll().ToList();
            return (result, 0, 0);

        }


    }
}
