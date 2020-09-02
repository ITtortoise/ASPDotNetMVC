using CourseRegistrationSystem.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseRegistrationSystem.Framework.Entities
{
    public class Student : IEntity<int>
    {
        public int Id { get ; set ; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public IList<StudentRegistration> Courses { get; set; }
    }
}
