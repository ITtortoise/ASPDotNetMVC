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

        public async Task<object> GetStudentRegistrations(DataTablesAjaxRequestModel tableModel)
        {
            var result = await _studentRegistrationService.GetAllAsync(
                tableModel.SearchText,
                tableModel.GetSortText(new string[] { "enrollDate", "studentName", "courseTitle" }),
                tableModel.PageIndex, tableModel.PageSize);

            return new
            {
                recordsTotal = result.Total,
                recordsFiltered = result.TotalDisplay,
                data = (from item in result.Items
                        select new string[]
                        {
                                    item.EnrollDate.ToString("dd MMMM, yyyy"),
                                    item.Student.Name,
                                    item.Course.Title,
                                    item.IsPaymentComplete.ToString(),
                                    item.Id.ToString()
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
