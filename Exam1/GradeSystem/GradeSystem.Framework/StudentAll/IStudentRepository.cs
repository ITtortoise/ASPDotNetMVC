using GradeSystem.Data;
using GradeSystem.Framework.ContexModule;
using GradeSystem.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeSystem.Framework.StudentAll
{
    public interface IStudentRepository : IRepository<Student, int, FrameworkContext>
    {
    }
}
