using CourseRegistrationSystem.Framework.Entities;
using CourseRegistrationSystem.Framework.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationSystem.Web.Areas.Admin.Models.StudentModelFiles
{
    public class CreateStudentModel : StudentBaseModel
    {
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public CreateStudentModel(IStudentService studentService) : base(studentService) { }
        public CreateStudentModel() : base() { }

        internal void Create()
        {
            var newstudent = new Student
            {
                Name = this.Name,
               
            };
            _studentService.CreateStudent(newstudent);
        }
    }
}
