using System;
using System.Collections.Generic;
using System.Text;

namespace CourseRegistrationSystem.Data
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
