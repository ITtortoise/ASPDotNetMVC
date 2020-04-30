using Autofac;
using MBSTU.OnlineShopping.Information.Repository;
using MBSTU.OnlineShopping.Information.Service;
using MBSTU.OnlineShopping.Information.Unitofwork;
using MBSTU.OnlineShopping.Information.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace MBSTU.OnlineShopping.Information.ContextModule
{
    public class InformationModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public InformationModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<InformationContext>()
                   .WithParameter("connectionString", _connectionString)
                   .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                   .InstancePerLifetimeScope();

            builder.RegisterType<InformationContext>().As<IInformationContext>()
                   .WithParameter("connectionString", _connectionString)
                   .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                   .InstancePerLifetimeScope();

            builder.RegisterType<PurchaseUnitofwork>().As<IPurchaseUnitofwork>()
                   .WithParameter("connectionString", _connectionString)
                   .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                   .InstancePerLifetimeScope();

            builder.RegisterType<ProductRepository>().As<IProductRepository>()
                .InstancePerLifetimeScope();
            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>()
                .InstancePerLifetimeScope();
            builder.RegisterType<PurchaseProductRepository>().As<IPurchaseProductRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ProductService>().As<IProductService>()
                .InstancePerLifetimeScope();
            builder.RegisterType<CustomerService>().As<ICustomerService>()
                .InstancePerLifetimeScope();
            builder.RegisterType<PurchaseProductService>().As<IPurchaseProductService>()
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
