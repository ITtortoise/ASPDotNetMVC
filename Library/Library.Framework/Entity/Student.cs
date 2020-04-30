using Library.Data.BaseIEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Framework.Entity
{
    public class Student : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Session { get; set; }
        public IList<StudentRegistration> StudentRegistrations { get; set; }
    }
}
