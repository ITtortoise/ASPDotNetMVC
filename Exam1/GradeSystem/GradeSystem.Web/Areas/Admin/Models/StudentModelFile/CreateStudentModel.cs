using GradeSystem.Framework.Entity;
using GradeSystem.Framework.RepositoryFile;
using GradeSystem.Framework.ServiceFile;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GradeSystem.Web.Areas.Admin.Models.StudentModelFile
{
    public class CreateStudentModel : StudentBaseModel
    {
        [StringLength(60,MinimumLength =3)]
        [Required]
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        public CreateStudentModel(IStudentService studentService) :base(studentService) { }
        public CreateStudentModel() : base() { }

        internal void Create()
        {
            var newstudent = new Student
            {
                Name = this.Name,
                Username = this.Username,
                Email = this.Email
            };
            _studentService.CreateStudent(newstudent);
        }
    }
}
