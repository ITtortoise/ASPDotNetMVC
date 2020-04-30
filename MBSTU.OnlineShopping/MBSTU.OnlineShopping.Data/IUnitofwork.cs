using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MBSTU.OnlineShopping.Data
{
   
        public interface IUnitofwork<TEntity> : IDisposable where TEntity : DbContext
        {
            void SaveChanges();
            Task SaveChangesAsync();
        }
    
}
