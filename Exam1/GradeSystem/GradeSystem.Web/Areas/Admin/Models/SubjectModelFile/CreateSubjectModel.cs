using GradeSystem.Framework.Entity;
using GradeSystem.Framework.ServiceFile;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GradeSystem.Web.Areas.Admin.Models.SubjectModelFile
{
    public class CreateSubjectModel : SubjectBaseModel
    {
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        public bool RegistrationOpen { get; set; }

        public CreateSubjectModel(ISubjectService subjectService) : base(subjectService) { }
        public CreateSubjectModel() : base() { }

        internal void Create()
        {
            var newsubject = new Subject
            {
                Name = this.Name,
                RegistrationOpen = this.RegistrationOpen
            };
            _subjectService.CreateSubject(newsubject);
        }
    }
}
