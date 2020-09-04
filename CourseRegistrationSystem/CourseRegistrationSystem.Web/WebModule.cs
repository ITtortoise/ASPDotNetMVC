using Autofac;
using CourseRegistrationSystem.Web.Areas.Admin.Models.CourseModelFiles;
using CourseRegistrationSystem.Web.Areas.Admin.Models.StudentModelFiles;
using CourseRegistrationSystem.Web.Areas.Admin.Models.StudentRegistrationModelFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistrationSystem.Web
{
    public class WebModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public WebModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CourseModel>();
            builder.RegisterType<StudentModel>();
            builder.RegisterType<StudentRegistrationModel>();
            base.Load(builder);
        }
    }
}
