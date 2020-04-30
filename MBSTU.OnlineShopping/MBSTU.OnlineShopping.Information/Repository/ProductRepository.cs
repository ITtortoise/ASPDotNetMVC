using MBSTU.OnlineShopping.Data;
using MBSTU.OnlineShopping.Information.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MBSTU.OnlineShopping.Information.Repository
{
    public class ProductRepository : Repository<Product> ,IProductRepository
    {
        public ProductRepository(DbContext dbContext)
            : base(dbContext)
        {

        }
    }
}
