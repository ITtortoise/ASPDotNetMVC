using MBSTU.OnlineCourse.Data.Class;
using MBSTU.OnlineCourse.Framework.Entity;
using MBSTU.OnlineCourse.Framework.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MBSTU.OnlineCourse.Framework.Class
{
    public class StudentRegistrationRepository : Repository<StudentRegistration>, IStudentRegistrationRepository
    {
        public StudentRegistrationRepository(DbContext dbContext)
            : base(dbContext)
        {

        }


    }
}
