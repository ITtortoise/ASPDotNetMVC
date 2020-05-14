using GradeSystem.Framework.Entity;
using GradeSystem.Framework.ServiceFile;
using GradeSystem.Web.Areas.Admin.Models.StudentModelFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeSystem.Web.Areas.Admin.Models.SubjectModelFile
{
    public class EditSubjectModel : SubjectBaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool RegistrationOpen { get; set; }
        public EditSubjectModel(ISubjectService subjectService) : base(subjectService) { }
        public EditSubjectModel() : base() { }
        internal void Load(int id)
        {
           var subject = _subjectService.GetSubById(id);
            if (subject != null)
            {
                Name = subject.Name;
                RegistrationOpen = subject.RegistrationOpen;
            }

        }

        internal void Edit()
        {
            var subject = new Subject
            {
                Id = this.Id,
                Name = this.Name,
                RegistrationOpen =this.RegistrationOpen
            };
            _subjectService.EditSubject(subject);
        }
    }
}
