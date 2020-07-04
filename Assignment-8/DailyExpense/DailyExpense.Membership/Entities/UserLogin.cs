using System;

using Microsoft.AspNetCore.Identity;

namespace DailyExpense.Membership.Entities
{
    public class UserLogin
        : IdentityUserLogin<Guid>
    {
        public UserLogin()
            : base()
        {

        }
    }
}
