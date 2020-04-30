using System;
using System.Collections.Generic;
using System.Text;

namespace MBSTU.OnlineShopping.Information.Entity
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string BranchName { get; set; }
        public IList<PurchaseProduct> PurchaseProducts { get; set; }
    }
}
