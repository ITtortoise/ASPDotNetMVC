using GradeSystem.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeSystem.Framework.Entity
{
    public class Student : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set;}
        public string Email { get; set; }
        public IList<Grade> Grades { get; set; }
    }
}
