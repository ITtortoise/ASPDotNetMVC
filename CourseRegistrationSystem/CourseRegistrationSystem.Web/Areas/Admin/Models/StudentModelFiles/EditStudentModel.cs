using CourseRegistrationSystem.Framework.Entities;
using CourseRegistrationSystem.Framework.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationSystem.Web.Areas.Admin.Models.StudentModelFiles
{
    public class EditStudentModel : StudentBaseModel
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public EditStudentModel(IStudentService studentService) : base(studentService) { }
        public EditStudentModel() : base() { }
        internal void Load(int id)
        {
            var student = _studentService.GetStudentbyId(id);
            if (student != null)
            {
                Id = student.Id;
                Name = student.Name;
                DateOfBirth = student.DateOfBirth;
            }
        }
        internal void Edit()
        {
            var student = new Student
            {
                Id = this.Id,
                Name = this.Name,
                DateOfBirth = this.DateOfBirth
            };

            _studentService.UpdateStudent(student);
        }


    }
}
