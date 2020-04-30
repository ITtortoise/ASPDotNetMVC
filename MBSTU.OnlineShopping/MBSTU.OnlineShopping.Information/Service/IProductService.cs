using MBSTU.OnlineShopping.Information.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MBSTU.OnlineShopping.Information.Service
{
    public interface IProductService 
    {
        Task<(IList<Product> Items, int Total, int TotalDisplay)> GetAllAsync(
           string searchText,
           string orderBy,
           int pageIndex,
           int pageSize);

        Task<Product> GetByIdAsync(int id);
        Task AddAsync(Product entity);
        Task UpdateAsync(Product entity);
        Task DeleteAsync(int id);
    }
}
