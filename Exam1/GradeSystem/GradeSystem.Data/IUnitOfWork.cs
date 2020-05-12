using System;
using System.Collections.Generic;
using System.Text;

namespace GradeSystem.Data
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
