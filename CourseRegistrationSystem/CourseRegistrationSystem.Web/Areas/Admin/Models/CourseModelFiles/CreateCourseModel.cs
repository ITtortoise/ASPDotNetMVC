using CourseRegistrationSystem.Framework.Entities;
using CourseRegistrationSystem.Framework.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationSystem.Web.Areas.Admin.Models.CourseModelFiles
{
    public class CreateCourseModel : CourseBaseModel
    {
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }
        public int SeatCount { get; set; }
        public int Fee { get; set; }
        public CreateCourseModel(ICourseService courseService) : base(courseService) { }
        public CreateCourseModel() : base() { }

        internal void Create()
        {
            var newCourse = new Course
            {
                Title = this.Title,
                SeatCount = this.SeatCount,
                Fee = this.Fee

            };
            _courseService.CreateCourse(newCourse);
        }
    }
}
