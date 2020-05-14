using GradeSystem.Framework.Entity;
using GradeSystem.Framework.UnitOfWorkFile;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace GradeSystem.Framework.ServiceFile
{
    public class SubjectService : ISubjectService
    {
        private IResultUnitOfWork _resultUnitOfWork;
        public SubjectService(IResultUnitOfWork resultUnitOfWork)
        {
            _resultUnitOfWork = resultUnitOfWork;
        }

        public void CreateSubject(Subject newsubject)
        {
            var count = _resultUnitOfWork.SubjectRepository.GetCount(x => x.Name == newsubject.Name);
            if (count > 0)
                throw new DuplicateWaitObjectException("Subject Title Exists", nameof(newsubject.Name));
            _resultUnitOfWork.SubjectRepository.Add(newsubject);
            _resultUnitOfWork.Save();
        }

        public void DelSubject(int id)
        {
            _resultUnitOfWork.SubjectRepository.Remove(id);
            _resultUnitOfWork.Save();
        }

        public void Dispose()
        {
            _resultUnitOfWork?.Dispose();
        }

        public void EditSubject(Subject subject)
        {
            var count = _resultUnitOfWork.SubjectRepository.GetCount(x => x.Name == subject.Name && x.Id != subject.Id);
            if (count > 0)
                throw new DuplicateWaitObjectException("Title exists..try with different One", nameof(subject.Name));
            var existingsub = _resultUnitOfWork.SubjectRepository.GetById(subject.Id);
            existingsub.Name = subject.Name;
            existingsub.RegistrationOpen = subject.RegistrationOpen;
            _resultUnitOfWork.SubjectRepository.Edit(existingsub);
            _resultUnitOfWork.Save();
        }

        public Subject GetSubById(int id)
        {
            return _resultUnitOfWork.SubjectRepository.GetById(id);
        }

        public (IList<Subject> records, int total, int totalDisplay) GetSubjects(int pageIndex, int pageSize, string searchText, string sortText)
        {
           var result= _resultUnitOfWork.SubjectRepository.GetAll().ToList();
            return (result, 0, 0);
        }
    }
}
