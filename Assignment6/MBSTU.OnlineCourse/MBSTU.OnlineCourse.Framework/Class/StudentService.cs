using MBSTU.OnlineCourse.Framework.Entity;
using MBSTU.OnlineCourse.Framework.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MBSTU.OnlineCourse.Framework.Class
{
    public class StudentService : IStudentService
    {
        private IRegistrationUnitOfWork _repositoryUnitOfWork;

        public StudentService(IRegistrationUnitOfWork repositoryUnitOfWork)
        {
            _repositoryUnitOfWork = repositoryUnitOfWork;
        }

        public void AddNewStudent(Student student)
        {
            _repositoryUnitOfWork.StudentRepositroy.Add(student);
            _repositoryUnitOfWork.Save();
        }

        public void UpDateStudentInfo(Student student)
        {
            
        }
    }
}
