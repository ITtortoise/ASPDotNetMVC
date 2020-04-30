using MBSTU.OnlineShopping.Data;
using MBSTU.OnlineShopping.Information.Entity;
using MBSTU.OnlineShopping.Information.Unitofwork;
using MBSTU.OnlineShopping.Information.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MBSTU.OnlineShopping.Information.Service
{
    public class PurchaseProductService : IPurchaseProductService
    {
        private IPurchaseUnitofwork _purchaseUnitOfWork;

        public PurchaseProductService(PurchaseUnitofwork purchaseUnitOfWork)
        {
            _purchaseUnitOfWork = purchaseUnitOfWork;
        }

        public async Task<(IList<PurchaseProduct> Items, int Total, int TotalDisplay)> GetAllAsync(
            string searchText, string orderBy, int pageIndex, int pageSize)
        {
            var columnsMap = new Dictionary<string, Expression<Func<PurchaseProduct, object>>>()
            {
                ["enrollDate"] = v => v.OrderDate,
                ["productName"] = v => v.Product.Name,
                ["customerName"] = v => v.Customer.Name,
            };

            var result = await _purchaseUnitOfWork.PurchaseProductRepository.GetAsync<PurchaseProduct>(
                x => x, x => x.Product.Name.Contains(searchText) || x.Customer.Name.Contains(searchText),
                x => x.ApplyOrdering(columnsMap, orderBy),
                x => x.Include(y => y.Product).Include(y => y.Customer),
                pageIndex, pageSize, true);

            return (result.Items, result.Total, result.TotalDisplay);
        }

        public async Task<PurchaseProduct> GetByIdAsync(int productId, int customerId)
        {
            return await _purchaseUnitOfWork.PurchaseProductRepository.GetByIdAsync(productId, customerId);
        }

        public async Task<IList<object>> GetProductsForSelectAsync()
        {
            return await _purchaseUnitOfWork.ProductRepository.GetAsync<object>(x => new { Value = x.Id.ToString(), Text = x.Name }, null, null, null, true);
        }
          
        public async Task<IList<object>> GetCustomersForSelectAsync()
        {
            return await _purchaseUnitOfWork.CustomerRepository.GetAsync<object>(x => new { Value = x.Id.ToString(), Text = x.Name }, null, null, null, true);
        }

        public async Task<bool> IsExistsAsync(int productId, int customerId)
        {
            return await _purchaseUnitOfWork.PurchaseProductRepository.IsExistsAsync(x => x.ProductId == productId && x.CustomerId == customerId);
        }

        public async Task AddAsync(PurchaseProduct entity)
        {
            await _purchaseUnitOfWork.PurchaseProductRepository.AddAsync(entity);
            await _purchaseUnitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(PurchaseProduct entity)
        {
            var updateEntity = await GetByIdAsync(entity.ProductId, entity.ProductId);
            updateEntity.ProductId = entity.ProductId;
            updateEntity.CustomerId = entity.CustomerId;
            updateEntity.OrderDate = entity.OrderDate;
            updateEntity.IsPaymentComplete = entity.IsPaymentComplete;

            await _purchaseUnitOfWork.PurchaseProductRepository.UpdateAsync(updateEntity);
            await _purchaseUnitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int productId, int customerId)
        {
            await _purchaseUnitOfWork.PurchaseProductRepository.DeleteAsync(x => x.ProductId == productId && x.CustomerId == customerId);
            await _purchaseUnitOfWork.SaveChangesAsync();
        }
    }
}
