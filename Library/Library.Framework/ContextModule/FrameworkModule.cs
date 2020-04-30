using Autofac;
using Library.Framework.BookRepositories;
using Library.Framework.BookServices;
using Library.Framework.LUnitOfWork;
using Library.Framework.StudentRepositories;
using Library.Framework.StudentServices;

namespace Library.Framework.ContextModule
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

            builder.RegisterType<LibraryUnitOfWork>().As<ILibraryUnitOfWork>()
                .InstancePerLifetimeScope();

            builder.RegisterType<BookRepository>().As<IBookRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<BookService>().As<IBookService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<StudentRepository>().As<IStudentRepository>()
               .InstancePerLifetimeScope();

            builder.RegisterType<StudentService>().As<IStudentService>()
                .InstancePerLifetimeScope();
            

            //builder.RegisterType<StudentRegistrationRepository>().As<IStudentRegistrationRepository>()
            //  .InstancePerLifetimeScope();

            //builder.RegisterType<StudentRegistrationService>().As<IStudentRegistrationService>()
            //    .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
