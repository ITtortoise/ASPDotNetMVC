using CourseRegistrationSystem.Framework.Entities;
using CourseRegistrationSystem.Framework.Unitofwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseRegistrationSystem.Framework.Services
{
    public class StudentService : IStudentService
    {
        private IRegistrationUnitOfWork _resultUnitOfWork;
        public StudentService(IRegistrationUnitOfWork resultUnitOfWork)
        {
            _resultUnitOfWork = resultUnitOfWork;
        }

        public void CreateStudent(Student newstudent)
        {
            var count = _resultUnitOfWork.StudentRepository.GetCount(x => x.Name == newstudent.Name);
            if (count > 0)
                throw new DuplicateWaitObjectException("Students already exists", nameof(newstudent.Name));
            _resultUnitOfWork.StudentRepository.Add(newstudent);
            _resultUnitOfWork.Save();
        }
        public void UpdateStudent(Student student)
        {
            var count = _resultUnitOfWork.StudentRepository.GetCount(x => x.Name == student.Name
                                                                                 && x.Id != student.Id);
            if (count > 0)
                throw new DuplicateWaitObjectException("Student Name exists", nameof(student.Name));

            var exitstudent = _resultUnitOfWork.StudentRepository.GetById(student.Id);
            exitstudent.Name = student.Name;
            exitstudent.DateOfBirth = student.DateOfBirth;
            _resultUnitOfWork.StudentRepository.Edit(exitstudent);
            _resultUnitOfWork.Save();


        }

        public void DeleteStudent(int id)
        {
            _resultUnitOfWork.StudentRepository.Remove(id);
            _resultUnitOfWork.Save();
        }

        public void Dispose()
        {
            _resultUnitOfWork.Dispose();
        }

        public Student GetStudentbyId(int id)
        {
            return _resultUnitOfWork.StudentRepository.GetById(id);

        }

        public (IList<Student> records, int total, int totalDisplay) GetStudents(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result = _resultUnitOfWork.StudentRepository.GetAll().ToList();
            return (result, 0, 0);

        }


    }
}
  