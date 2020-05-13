using Autofac;
using GradeSystem.Framework.RepositoryFile;
using GradeSystem.Framework.ServiceFile;
using GradeSystem.Framework.UnitOfWorkFile;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeSystem.Framework.ContextModule
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

            builder.RegisterType<ResultUnitOfWork>().As<IResultUnitOfWork>()
                .InstancePerLifetimeScope();

            builder.RegisterType<SubjectRepository>().As<ISubjectRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<SubjectService>().As<ISubjectService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<StudentRepository>().As<IStudentRepository>()
               .InstancePerLifetimeScope();

            builder.RegisterType<StudentService>().As<IStudentService>()
                .InstancePerLifetimeScope();


            builder.RegisterType<GradeRepository>().As<IGradeRepository>()
              .InstancePerLifetimeScope();

            builder.RegisterType<GradeService>().As<IGradeService>()
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
