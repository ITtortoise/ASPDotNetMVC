using Library.Framework.StudentServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Web.Areas.Admin.Models.StudentModels
{
    public class DeleteStudentModel : StudentBaseModel
    {
       public int Id { get; set; }

        public DeleteStudentModel(IStudentService studentService) : base(studentService) { }
        public DeleteStudentModel() : base() { }

        public void Delete(int Id)
        { 
            _studentService.DelStudent(Id);
        }
    }
}
