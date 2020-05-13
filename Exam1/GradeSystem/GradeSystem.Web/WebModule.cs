using Autofac;
using GradeSystem.Web.Areas.Admin.Models.GradeModelFile;
using GradeSystem.Web.Areas.Admin.Models.StudentModelFile;
using GradeSystem.Web.Areas.Admin.Models.SubjectModelFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace GradeSystem.Web
{
    public class WebModule : Module
    {
        private readonly string  _connectionString ;
        private readonly string _migrationAssemblyName ;
        public WebModule(string connectionString ,string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StudentModel>();
            builder.RegisterType<SubjectModel>();
            builder.RegisterType<GradeModel>();

            base.Load(builder);
        }


    }
}
