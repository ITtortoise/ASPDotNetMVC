using Library.Framework.StudentRegistrationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Web.Areas.Admin.Models.RegistrationModels
{
    public class RegistrationModel : RegistrationBaseModel
    {
        public RegistrationModel(IStudentRegistrationService registrationService) : base(registrationService) { }
        public RegistrationModel() : base() { }
        internal object GetRecords(DataTablesAjaxRequestModel tableModel)
        {
            var data = _registrationService.GetRecords(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText,
                tableModel.GetSortText(new string[] { "StudentId", "BookId", "BorrowDate", "IsReturnComplete" }));

            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                                record.StudentId.ToString(),
                                record.BookId.ToString(),
                                record.BorrowDate.ToString(),
                                record.IsReturnComplete.ToString()
                        }
                    ).ToArray()

            };
        }

    }
}
