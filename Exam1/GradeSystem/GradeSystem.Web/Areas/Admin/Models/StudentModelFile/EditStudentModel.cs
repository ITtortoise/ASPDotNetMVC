using GradeSystem.Framework.Entity;
using GradeSystem.Framework.ServiceFile;
using GradeSystem.Web.Areas.Admin.Models.GradeModelFile;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GradeSystem.Web.Areas.Admin.Models.StudentModelFile
{
    public class EditStudentModel : StudentBaseModel
    {
        public int Id { get; set; }
        [StringLength (maximumLength:60,MinimumLength =3)]
        [Required]
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        public EditStudentModel(IStudentService studentService) : base(studentService) { }
        public EditStudentModel() : base() { }
        internal void Load(int id)
        {
           var student = _studentService.GetStudentbyId(id);
            if (student != null)
            {
                Id = student.Id;
                Name = student.Name;
                Username = student.Username;
                Email = student.Email;
            }
        }
        internal void Edit()
        {
            var student = new Student
            {
                Id = this.Id,
                Name = this.Name,
                Username = this.Username,
                Email = this.Email
            };

            _studentService.UpdateStudent(student);
        }

        
    }
}
