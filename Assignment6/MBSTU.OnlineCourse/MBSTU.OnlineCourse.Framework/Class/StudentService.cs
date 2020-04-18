using MBSTU.OnlineCourse.Framework.Entity;
using MBSTU.OnlineCourse.Framework.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MBSTU.OnlineCourse.Framework.Class
{
    public class StudentService : IStudentService
    {
        private IRegistrationUnitOfWork _registrationUnitOfWork;

        public StudentService(IRegistrationUnitOfWork registrationUnitOfWork)
        {
            _registrationUnitOfWork = registrationUnitOfWork;
        }

        public void AddNewStudent(Student student)
        {
            _registrationUnitOfWork.StudentRepository.Add(student);
            _registrationUnitOfWork.Save();
        }

        public void UpDateStudentInfo(Student student)
        {
            
        }
    }
}
