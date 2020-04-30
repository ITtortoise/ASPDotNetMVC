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
    public class CustomerService : ICustomerService
    {
        private IPurchaseUnitofwork _purchaseUnitOfWork;

        public CustomerService(IPurchaseUnitofwork purchaseUnitOfWork)
        {
            _purchaseUnitOfWork = purchaseUnitOfWork;
        }

        public async Task<(IList<Customer> Items, int Total, int TotalDisplay)> GetAllAsync(
            string searchText, string orderBy, int pageIndex, int pageSize)
        {
            var columnsMap = new Dictionary<string, Expression<Func<Customer, object>>>()
            {
                ["name"] = v => v.Name,
                ["phonenumber"] = v => v.PhoneNumber,
                ["email"] = v => v.Email,
                ["branchname"] = v => v.BranchName
            };

            var result = await _purchaseUnitOfWork.CustomerRepository.GetAsync<Customer>(
                x => x, x => x.Name.Contains(searchText),
                x => x.ApplyOrdering(columnsMap, orderBy),
                x => x.Include(y => y.PurchaseProducts)
                        .ThenInclude(y => y.Product),
                pageIndex, pageSize, true);

            return (result.Items, result.Total, result.TotalDisplay);
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            return await _purchaseUnitOfWork.CustomerRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(Customer entity)
        {
            await _purchaseUnitOfWork.CustomerRepository.AddAsync(entity);
            await _purchaseUnitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(Customer entity)
        {
            var updateEntity = await GetByIdAsync(entity.Id);
            updateEntity.Name = entity.Name;
            updateEntity.PhoneNumber = entity.PhoneNumber;
            updateEntity.Email = entity.Email;
            updateEntity.BranchName = entity.BranchName;

            await _purchaseUnitOfWork.CustomerRepository.UpdateAsync(updateEntity);
            await _purchaseUnitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _purchaseUnitOfWork.CustomerRepository.DeleteAsync(id);
            await _purchaseUnitOfWork.SaveChangesAsync();
        }
    }
}
