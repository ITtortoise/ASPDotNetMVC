using Autofac;
using MBSTU.OnlineCourse.Framework.Entity;
using MBSTU.OnlineCourse.Framework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MBSTU.OnlineCourse.Web.Areas.Admin.Models
{
    public class CourseModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int SeatCount { get; set; }
        public int Fee { get; set; }

        public void NewCourse()
        {
            var course = new Course
            {
                Title = this.Title,
                SeatCount = this.SeatCount,
                Fee = this.Fee
            };
            var service = Startup.AutofacContainer.Resolve<ICourseService>();
            service.AddNewCourse(course);

        }
    }
}
