using Library.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Framework.StudentRegistrationServices
{
    public interface IStudentRegistrationService : IDisposable
    {
        
        (IList<StudentRegistration> records, int total, int totalDisplay) GetRecords(int pageIndex,
                                                                  int pageSize,
                                                                  string searchText,
                                                                  string sortText);
        void AddNewRecord(StudentRegistration newRecord);

    }
}
