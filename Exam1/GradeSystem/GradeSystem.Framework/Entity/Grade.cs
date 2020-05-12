using GradeSystem.Data;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeSystem.Framework.Entity
{
    public class Grade : IEntity<int>
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public Subject Subject { get; set; }
        public int SubjectId { get; set; }


    }
}
