using MBSTU.OnlineCourse.Framwork.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MBSTU.OnlineCourse.Framework.Interface
{
    public interface IStudentService
    {
        (IList<Student> records, int total, int totalDisplay) GetStudents(int pageIndex,
                                                                    int pageSize,
                                                                    string searchText,
                                                                    string sortText);
    }
}
