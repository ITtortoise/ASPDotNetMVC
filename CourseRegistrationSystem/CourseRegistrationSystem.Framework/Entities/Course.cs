﻿using CourseRegistrationSystem.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseRegistrationSystem.Framework.Entities
{
    public class Course : IEntity<int>
    {
        public int  Id { get; set; }
        public string Title { get; set; }
        public int SeatCount { get; set; }
        public int Fee { get; set; }
        public IList<StudentRegistration> Students { get; set; }
    }
}
