using MBSTU.OnlineShopping.Data;
using MBSTU.OnlineShopping.Information.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MBSTU.OnlineShopping.Information.Repository
{
    public class PurchaseProductRepository : Repository<PurchaseProduct> , IPurchaseProductRepository
    {
        public PurchaseProductRepository(DbContext dbContext)
            : base(dbContext)
        {

        }
    }
}
