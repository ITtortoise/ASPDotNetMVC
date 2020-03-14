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
            var products = dbProvider.GetData("spGetProducts", new List<(string, object, bool)>
            {
                ("PageIndex", pageIndex, false),
                ("PageSize", pageSize , false),
                ("SearchText", searchText , false),
                ("OrderBy", sortText, false),
                ( "Total", 0, true),
                ( "TotalDisplay", 0, true)
            });

            return (products.result, products.total, products.totalDisplay);
        }
    }
}

