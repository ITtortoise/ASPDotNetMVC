using GradeSystem.Framework.Entity;
using GradeSystem.Framework.GradeUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeSystem.Framework.SubjectAll
{
    public class SubjectService : ISubjectService
    {
        private IGradingUnitOfWork _gradingUnitOfWork;

        public SubjectService(GradingUnitOfWork gradingUnitOfWork)
        {
            _gradingUnitOfWork = gradingUnitOfWork;
        }
        public void CreateSubject(Subject subject)
        {
            _gradingUnitOfWork.SubjectRepository.Add(subject);
            _gradingUnitOfWork.Save();
        }

        public void Dispose()
        {
            _gradingUnitOfWork?.Dispose();
        }

        public (IList<Subject> records, int total, int totalDisplay) GetSubjects(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result = _gradingUnitOfWork.SubjectRepository.GetAll().ToList();
            return (result, 0, 0);
        }

    }
}
