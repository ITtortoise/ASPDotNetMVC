using Autofac;
using Library.Web.Areas.Admin.Models.BookModels;
using Library.Web.Areas.Admin.Models.RegistrationModels;
using Library.Web.Areas.Admin.Models.StudentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Web
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
            builder.RegisterType<BookModel>();
            builder.RegisterType<StudentModel>();
            builder.RegisterType<RegistrationModel>();
            base.Load(builder);
        }
    }
}
