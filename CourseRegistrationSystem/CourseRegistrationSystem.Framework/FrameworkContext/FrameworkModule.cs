﻿using Autofac;
using CourseRegistrationSystem.Framework.Repositories;
using CourseRegistrationSystem.Framework.Services;
using CourseRegistrationSystem.Framework.Unitofwork;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseRegistrationSystem.Framework.FrameworkContext
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

            builder.RegisterType<RegistrationUnitOfWork>().As<IRegistrationUnitOfWork>()
                .InstancePerLifetimeScope();

            builder.RegisterType<CourseRepository>().As<ICourseRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<CourseService>().As<ICourseService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<StudentRepository>().As<IStudentRepository>()
               .InstancePerLifetimeScope();

            builder.RegisterType<StudentService>().As<IStudentService>()
                .InstancePerLifetimeScope();


            builder.RegisterType<StudentRegistrationRepository>().As<IStudentRegistrationRepository>()
              .InstancePerLifetimeScope();

            builder.RegisterType<StudentRegistrationService>().As<IStudentRegistrationService>()
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
