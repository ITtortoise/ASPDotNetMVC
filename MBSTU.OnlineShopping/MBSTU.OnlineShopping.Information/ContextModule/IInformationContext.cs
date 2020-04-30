using MBSTU.OnlineShopping.Information.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MBSTU.OnlineShopping.Information.ContextModule
{
    public interface IInformationContext
    {
         DbSet<Product> Products { get; set; }
         DbSet<Customer> Customers { get; set; }
         DbSet<PurchaseProduct> PurchaseProducts { get; set; }
    }
}
