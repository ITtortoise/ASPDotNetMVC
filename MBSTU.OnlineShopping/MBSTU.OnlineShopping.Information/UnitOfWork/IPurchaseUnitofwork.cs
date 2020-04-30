using MBSTU.OnlineShopping.Data;
using MBSTU.OnlineShopping.Information.ContextModule;
using MBSTU.OnlineShopping.Information.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace MBSTU.OnlineShopping.Information.UnitOfWork
{
   
        public interface IPurchaseUnitofwork : IUnitofwork<InformationContext>
        {
            IProductRepository ProductRepository { get; set; }
            ICustomerRepository CustomerRepository { get; set; }
            IPurchaseProductRepository PurchaseProductRepository { get; set; }
        }
    
}
