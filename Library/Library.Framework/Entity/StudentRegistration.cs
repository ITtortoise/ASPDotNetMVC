using Library.Data.BaseIEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Framework.Entity
{
    public class StudentRegistration : IEntity<int>
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public DateTime BorrowDate { get; set; }
        public bool IsReturnComplete { get; set; }
    }
}
