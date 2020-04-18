using MBSTU.OnlineCourse.Framework.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MBSTU.OnlineCourse.Framework.Class
{
    public class StudentRegistrationService : IStudentRegistrationService
    {
        private IRegistrationUnitOfWork _repositoryUnitOfWork;

        public StudentRegistrationService(IRegistrationUnitOfWork repositoryUnitOfWork)
        {
            _repositoryUnitOfWork = repositoryUnitOfWork;
        }

    }
}
