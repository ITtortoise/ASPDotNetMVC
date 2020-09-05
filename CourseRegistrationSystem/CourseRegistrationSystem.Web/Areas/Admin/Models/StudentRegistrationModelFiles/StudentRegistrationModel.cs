using CourseRegistrationSystem.Framework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationSystem.Web.Areas.Admin.Models.StudentRegistrationModelFiles
{
    public class StudentRegistrationModel : StudentRegistrationBaseModel
    {
        public StudentRegistrationModel(IStudentRegistrationService studentRegistrationService) : base(studentRegistrationService) { }
        public StudentRegistrationModel() : base() { }

        internal object GetStudentRegistrations(DataTablesAjaxRequestModel tableModel)
        {
            var data = _studentRegistrationService.GetStudentRegistrations(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText,
                tableModel.GetSortText(new string[] { "StudentId", "CourseId", "EnrollDate" }));
            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                            record.StudentId.ToString(),
                            record.CourseId.ToString(),
                            record.EnrollDate.ToString(),
                            record.IsPaymentComplete.ToString(),
                            record.Id.ToString()
                        }
                    ).ToArray()

            };
        }

        internal void Delete(int id)
        {
            _studentRegistrationService.DeleteStudentRegistration(id);
        }
    }
}
