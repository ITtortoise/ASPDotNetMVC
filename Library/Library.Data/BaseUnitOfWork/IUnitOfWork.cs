using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Data.BaseUnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
