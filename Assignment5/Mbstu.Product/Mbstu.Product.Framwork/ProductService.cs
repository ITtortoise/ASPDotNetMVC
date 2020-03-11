using Mbstu.Product.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mbstu.Product.Framwork
{
    public class ProductService : IProductService
    {
        private string _connectionString;

        public ProductService(string connectionString)
        {
            _connectionString = connectionString;
        }


        public (IList<Product> records, int total, int totalDisplay) GetProducts(int pageIndex,
             int pageSize, string searchText, string sortText)
        {
            using var dbProvider = new SqlServerDataProvider<Product>(_connectionString);
            var filteredProducts = dbProvider.GetProductList(pageIndex,pageSize,sortText,searchText);
            dbProvider.Dispose();
            using var dbProvider1 = new SqlServerDataProvider<Product>(_connectionString);
            var Products = dbProvider1.GetData("Select * from Products");
            //var filteredBooks = products.Where(x => x.Name.Contains(searchText)
            //    || x.Description.Contains(searchText));
            
            var filteredProductsCount = filteredProducts.Count();
            var totalProducts = Products.Count();

            //var filteredBooksList = filteredBooks.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

            return (filteredProducts, totalProducts, filteredProductsCount);
        }
    }
}

