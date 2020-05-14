using GradeSystem.Framework.UnitOfWorkFile;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeSystem.Framework.ServiceFile
{
    public class GradeService : IGradeService
    {
        private IResultUnitOfWork _resultUnitOfWork;
        public GradeService (IResultUnitOfWork resultUnitOfWork)
        {
            _resultUnitOfWork = resultUnitOfWork;
        }
        public void Dispose()
        {
            _resultUnitOfWork.Dispose();
        }
    }
}
