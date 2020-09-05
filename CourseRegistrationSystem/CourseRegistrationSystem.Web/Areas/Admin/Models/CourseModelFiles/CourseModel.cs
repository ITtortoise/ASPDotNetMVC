using CourseRegistrationSystem.Framework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationSystem.Web.Areas.Admin.Models.CourseModelFiles
{
    public class CourseModel : CourseBaseModel
    {
        public CourseModel(ICourseService courseService) : base(courseService) { }
        public CourseModel() : base() { }

        internal object GetCourses(DataTablesAjaxRequestModel tableModel)
        {
            var data = _courseService.GetCourses(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText,
                tableModel.GetSortText(new string[] { "Title" }));
            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                            record.Title,
                            record.SeatCount.ToString(),
                            record.Fee.ToString(),
                            record.Id.ToString()
                        }
                    ).ToArray()

            };
        }

        internal void Delete(int id)
        {
            _courseService.DeleteCourse(id);
        }
    }
}
