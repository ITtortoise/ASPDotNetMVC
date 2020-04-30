using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MBSTU.OnlineShopping.Data
{
    public class Unitofwork<TEntity> : IUnitofwork<TEntity> where TEntity : DbContext
    {
        protected readonly TEntity _dbContext;

        public Unitofwork(string connectionString, string migrationAssemblyName)
            => _dbContext = (TEntity)Activator.CreateInstance(typeof(TEntity), connectionString, migrationAssemblyName);

        public void SaveChanges() => _dbContext?.SaveChanges();
        public Task SaveChangesAsync() => _dbContext?.SaveChangesAsync();

        public void Dispose() => _dbContext?.Dispose();
    }
}
