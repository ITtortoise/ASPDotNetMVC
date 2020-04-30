using MBSTU.OnlineShopping.Data;
using MBSTU.OnlineShopping.Information.ContextModule;
using MBSTU.OnlineShopping.Information.Repository;
using MBSTU.OnlineShopping.Information.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace MBSTU.OnlineShopping.Information.Unitofwork
{
    public class PurchaseUnitofwork : Unitofwork<InformationContext>, IPurchaseUnitofwork
    {
       
            public IProductRepository ProductRepository { get; set; }
            public ICustomerRepository CustomerRepository { get; set; }
            public IPurchaseProductRepository PurchaseProductRepository { get; set; }

            public PurchaseUnitofwork(string connectionString, string migrationAssemblyName)
                : base(connectionString, migrationAssemblyName)
            {
                ProductRepository = new ProductRepository(_dbContext);
                CustomerRepository = new CustomerRepository(_dbContext);
                PurchaseProductRepository = new PurchaseProductRepository(_dbContext);
            }
        }
    }

