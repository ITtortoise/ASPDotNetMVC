using System;

using Microsoft.AspNetCore.Identity;

namespace DailyExpense.Membership.Entities
{
    public class UserClaim
        : IdentityUserClaim<Guid>
    {
        public UserClaim()
            : base()
        {

        }
    }
}
