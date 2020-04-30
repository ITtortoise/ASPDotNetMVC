using Library.Data.BaseIEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Framework.Entity
{
    public class Book : IEntity<int>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Edition { get; set; }
        public IList<StudentRegistration> StudentRegistrations { get; set; }
    }
}
