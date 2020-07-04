using System;
using System.Collections.Generic;
using System.Text;
using DailyExpense.Membership.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DailyExpense.Membership
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, Role, Guid,
         UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
