using System;

using Microsoft.AspNetCore.Identity;

namespace DailyExpense.Membership.Entities
{
    public class RoleClaim
        : IdentityRoleClaim<Guid>
    {
        public RoleClaim()
            : base()
        {

        }
    }
}
