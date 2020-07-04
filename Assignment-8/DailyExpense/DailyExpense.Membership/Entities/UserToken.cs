using System;

using Microsoft.AspNetCore.Identity;

namespace DailyExpense.Membership.Entities
{
    public class UserToken
        : IdentityUserToken<Guid>
    {
        public UserToken()
            : base()
        {

        }
    }
}
