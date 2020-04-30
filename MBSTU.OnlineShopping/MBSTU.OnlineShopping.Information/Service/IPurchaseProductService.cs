using MBSTU.OnlineShopping.Information.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MBSTU.OnlineShopping.Information.Service
{
    public interface IPurchaseProductService
    {
            Task<(IList<PurchaseProduct> Items, int Total, int TotalDisplay)> GetAllAsync(
                string searchText,
                string orderBy,
                int pageIndex,
                int pageSize);

            Task<PurchaseProduct> GetByIdAsync(int productId, int customerId);
            Task<IList<object>> GetProductsForSelectAsync();
            Task<IList<object>> GetCustomersForSelectAsync();
            Task<bool> IsExistsAsync(int studentId, int courseId);
            Task AddAsync(PurchaseProduct entity);
            Task UpdateAsync(PurchaseProduct entity);
            Task DeleteAsync(int ProductId, int customerId);
        }
    }
