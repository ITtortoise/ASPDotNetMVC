using GradeSystem.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeSystem.Framework.SubjectAll
{
    public interface ISubjectService : IDisposable
    {
        (IList<Subject> records, int total, int totalDisplay) GetSubjects(int pageIndex,
                                                                  int pageSize,
                                                                  string searchText,
                                                                  string sortText);
        void CreateSubject(Subject student);
    }
}
