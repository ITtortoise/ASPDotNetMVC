using Library.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Library.Web.Areas.Admin.Models.RegistrationModels
{
    public class CreateRegistrationModel :RegistrationBaseModel
    {
        public int StudentId { get; set; }
        public int BookId { get; set; }
        public DateTime BorrowDate { get; set; }
        public bool IsReturnComplete { get; set; }

        public  void AddNew()
        {
           var newRecord = new StudentRegistration
           {
               StudentId =this.StudentId,
               BookId= this.BookId,
               BorrowDate =this.BorrowDate,
               IsReturnComplete = this.IsReturnComplete

           };
            _registrationService.AddNewRecord(newRecord);
        }
    }
}
