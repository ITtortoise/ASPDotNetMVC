using MBSTU.OnlineShopping.Information.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MBSTU.OnlineShopping.Information.Service
{
    public interface ICustomerService
    {
        Task<(IList<Customer> Items, int Total, int TotalDisplay)> GetAllAsync(
           string searchText,
           string orderBy,
           int pageIndex,
           int pageSize);

        Task<Customer> GetByIdAsync(int id);
        Task AddAsync(Customer entity);
        Task UpdateAsync(Customer entity);
        Task DeleteAsync(int id);
    }
}
