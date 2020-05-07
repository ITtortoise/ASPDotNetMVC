using Library.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Framework.StudentRegistrationServices
{
    public interface IStudentRegistrationService : IDisposable
    {
        void AddNewRecord(StudentRegistration newRecord);
    }
}
