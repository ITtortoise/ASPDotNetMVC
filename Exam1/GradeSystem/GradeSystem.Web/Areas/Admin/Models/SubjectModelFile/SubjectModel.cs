using GradeSystem.Framework.ServiceFile;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeSystem.Web.Areas.Admin.Models.SubjectModelFile
{
    public class SubjectModel : SubjectBaseModel
    {
        public SubjectModel(ISubjectService subjectService) : base(subjectService) { }
        public SubjectModel() : base() { }
        internal Object GetSubjects(DataTablesAjaxRequestModel tableModel)
        {
            var data = _subjectService.GetSubjects(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText,
                tableModel.GetSortText(new string [] {"Name","RegistrationOpen"}));
            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                            record.Name,
                            record.RegistrationOpen.ToString(),
                            record.Id.ToString()
                        }
                   ).ToArray()

            };
        }
        internal void Delete(int id)
        {
            _subjectService.DelSubject(id);
        }
    }
}
