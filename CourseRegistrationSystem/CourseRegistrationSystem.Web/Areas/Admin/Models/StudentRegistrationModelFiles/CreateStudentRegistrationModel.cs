using CourseRegistrationSystem.Framework.Entities;
using CourseRegistrationSystem.Framework.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationSystem.Web.Areas.Admin.Models.StudentRegistrationModelFiles
{
    public class CreateStudentRegistrationModel : StudentRegistrationBaseModel
    {
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public int StudentId { get; set; }
        public int  CourseId { get; set; }
        public DateTime EnrollDate { get; set; }
        public bool IsPaymentComplete { get; set; }
        public CreateStudentRegistrationModel(IStudentRegistrationService studentRegistrationService) : base(studentRegistrationService) { }
        public CreateStudentRegistrationModel() : base() { }

        internal void Create()
        {
            var newstudentRegistration = new StudentRegistration
            {
                StudentId = this.StudentId,
                CourseId = this.CourseId,
                EnrollDate = this.EnrollDate,
                IsPaymentComplete = this.IsPaymentComplete
            };
            _studentRegistrationService.CreateStudentRegistration(newstudentRegistration);
        }
    }
}
