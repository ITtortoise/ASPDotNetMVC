using Autofac;
using EFProjectDemo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFProjectDemo.Models
{
    public class ProductModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public void CreateProduct()
        {
            var context = Startup.AutofacContainer.Resolve<StoreContext>();
            context.Products.Add(new Product
            {
                Name = this.Name,
                Description = this.Description,
                Price = this.Price,
            });

            //var product = context.Products.Where(x => x.Id == 1).FirstOrDefault();
            //product.Price = 6000;

            //context.Products.Remove(product);

            context.SaveChanges();
         
        }
        public void CreateCategory()
        {
            var context = Startup.AutofacContainer.Resolve<StoreContext>();
            context.Categories.Add(new Category
            {
                Name = this.Name,
            });

            context.SaveChanges();

        }
    }
}
