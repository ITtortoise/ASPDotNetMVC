using MBSTU.OnlineShopping.Data;
using MBSTU.OnlineShopping.Information.Entity;
using MBSTU.OnlineShopping.Information.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MBSTU.OnlineShopping.Information.Service
{
    public class ProductService : IProductService 
    {
        private IPurchaseUnitofwork _purchaseUnitOfWork;

        public ProductService(IPurchaseUnitofwork purchaseUnitOfWork)
        {
            _purchaseUnitOfWork = purchaseUnitOfWork;
        }

        public async Task<(IList<Product> Items, int Total, int TotalDisplay)> GetAllAsync(
            string searchText, string orderBy, int pageIndex, int pageSize)
        {
            var columnsMap = new Dictionary<string, Expression<Func<Product, object>>>()
            {
                ["name"] = v => v.Name,
                ["description"] = v => v.Description,
                ["price"] = v => v.Price
            };

            var result = await _purchaseUnitOfWork.ProductRepository.GetAsync<Product>(
                x => x, x => x.Name.Contains(searchText),
                x => x.ApplyOrdering(columnsMap, orderBy),
                x => x.Include(y => y.PurchaseProducts)
                        .ThenInclude(y => y.Product),
                pageIndex, pageSize, true);

            return (result.Items, result.Total, result.TotalDisplay);
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _purchaseUnitOfWork.ProductRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(Product entity)
        {
            await _purchaseUnitOfWork.ProductRepository.AddAsync(entity);
            await _purchaseUnitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(Product entity)
        {
            var updateEntity = await GetByIdAsync(entity.Id);
            updateEntity.Name = entity.Name;
            updateEntity.Description = entity.Description;
            updateEntity.Price = entity.Price;

            await _purchaseUnitOfWork.ProductRepository.UpdateAsync(updateEntity);
            await _purchaseUnitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _purchaseUnitOfWork.ProductRepository.DeleteAsync(id);
            await _purchaseUnitOfWork.SaveChangesAsync();
        }
    }
}
