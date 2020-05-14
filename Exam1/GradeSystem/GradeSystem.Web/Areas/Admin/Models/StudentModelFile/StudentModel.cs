using GradeSystem.Framework.ServiceFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace GradeSystem.Web.Areas.Admin.Models.StudentModelFile
{
    public class StudentModel : StudentBaseModel
    {
        public StudentModel(IStudentService studentService) : base(studentService) { }
        public StudentModel () : base() { }

        internal object GetStudents(DataTablesAjaxRequestModel tableModel)
        {
            var data = _studentService.GetStudents(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText,
                tableModel.GetSortText(new string[] { "Name", "Username", "Email" }));
            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                            record.Name,
                            record.Username,
                            record.Email,
                            record.Id.ToString()
                        }
                    ).ToArray()

            };
        }

        internal void Delete(int id)
        {
            _studentService.DeleteStudent(id);
        }
    }
}
