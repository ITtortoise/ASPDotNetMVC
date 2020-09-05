using CourseRegistrationSystem.Framework.Entities;
using CourseRegistrationSystem.Framework.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationSystem.Web.Areas.Admin.Models.CourseModelFiles
{
    public class EditCourseModel : CourseBaseModel
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }
        public int SeatCount { get; set; }
        public int Fee { get; set; }

        public EditCourseModel(ICourseService courseService) : base(courseService) { }
        public EditCourseModel() : base() { }
        internal void Load(int id)
        {
            var course = _courseService.GetCourseById(id);
            if (course != null)
            {
                Id = course.Id;
                Title = course.Title;
                SeatCount = course.SeatCount;
                Fee = course.Fee;
            }
        }
        internal void Edit()
        {
            var course = new Course
            {
                Id = this.Id,
                Title = this.Title,
                SeatCount  = this.SeatCount,
                Fee = this.Fee
            };

            _courseService.EditCourse(course);
        }


    }
}
