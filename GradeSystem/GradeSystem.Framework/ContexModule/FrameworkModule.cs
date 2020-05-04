using Autofac;
using GradeSystem.Framework.GradeUnitOfWork;
using GradeSystem.Framework.StudentAll;
using GradeSystem.Framework.SubjectAll;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeSystem.Framework.ContexModule
{
    public class FrameworkModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public FrameworkModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FrameworkContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();

            builder.RegisterType<GradingUnitOfWork>().As<IGradingUnitOfWork>()
                .InstancePerLifetimeScope();

            builder.RegisterType<SubjectRepository>().As<ISubjectRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<SubjectService>().As<ISubjectService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<StudentRepository>().As<IStudentRepository>()
               .InstancePerLifetimeScope();

            builder.RegisterType<StudentService>().As<IStudentService>()
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
