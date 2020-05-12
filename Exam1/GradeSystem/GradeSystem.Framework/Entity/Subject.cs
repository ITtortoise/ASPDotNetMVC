using GradeSystem.Data;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeSystem.Framework.Entity
{
    public class Subject : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool RegistrationOpen { get; set; }
        public IList<Grade> Grades { get; set; }
    }
}
