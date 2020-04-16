using System;
using System.Collections.Generic;
using System.Text;

namespace MBSTU.OnlineCourse.Framwork.Entity
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int SeatCount { get; set; }
        public int Fee { get; set; }
        public IList<StudentRegistration> StudentRegistrations { get; set; }
    }
}
