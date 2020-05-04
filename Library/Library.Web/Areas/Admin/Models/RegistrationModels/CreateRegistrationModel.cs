using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Web.Areas.Admin.Models.RegistrationModels
{
    public class CreateRegistrationModel :RegistrationBaseModel
    {
        public int StudentId { get; set; }
        public int BookId { get; set; }
        public DateTime BorrowDate { get; set; }
        public bool IsReturnComplete { get; set; }

        public IList<object> StudentSelectList { get; set; }
        public IList<object> BookSelectList { get; set; }
        public  void AddNew()
        {
           
        }
    }
}
