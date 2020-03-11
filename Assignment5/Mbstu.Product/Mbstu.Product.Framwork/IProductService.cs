using System;
using System.Collections.Generic;
using System.Text;

namespace Mbstu.Product.Framwork
{
    public interface IProductService
    {
        (IList<Product> records, int total, int totalDisplay) GetProducts(int pageIndex,
                                                                     int pageSize,
                                                                     string searchText,
                                                                     string sortText);
    }
}

