using System;
using System.Collections.Generic;
using System.Text;

namespace MBSTU.OnlineShopping.Information.Entity
{
    public class PurchaseProduct
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsPaymentComplete { get; set; }
    }
}
