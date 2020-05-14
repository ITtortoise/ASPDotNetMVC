using Autofac;
using GradeSystem.Framework.ServiceFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeSystem.Web.Areas.Admin.Models.SubjectModelFile
{
    public class SubjectBaseModel : AdminBaseModel, IDisposable
    {
        protected readonly ISubjectService _subjectService;
        public SubjectBaseModel(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }
        public SubjectBaseModel()
        {
            _subjectService = Startup.AutofacContainer.Resolve<ISubjectService>();
        }
        public void Dispose()
        {
            _subjectService?.Dispose();
        }
    }
}
