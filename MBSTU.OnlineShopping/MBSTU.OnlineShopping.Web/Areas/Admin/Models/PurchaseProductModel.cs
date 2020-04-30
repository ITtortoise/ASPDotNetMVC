using Autofac;
using MBSTU.OnlineShopping.Information.Entity;
using MBSTU.OnlineShopping.Information.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MBSTU.OnlineShopping.Web.Areas.Admin.Models
{
    public class PurchaseProductModel : AdminBaseModel
    {
        [Required]
        [Display(Name = "Product")]
        public int ProductId { get; set; }
        [Required]
        [Display(Name = "CustomerId")]
        public int CustomerId { get; set; }
        [Required]
        [Display(Name = "Order Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd MMMM, yyyy}")]
        public DateTime? OrderDate { get; set; }
        [Required]
        [Display(Name = "Is Payment Complete")]
        public bool IsPaymentComplete { get; set; }

        public IList<object> ProductSelectList { get; set; }
        public IList<object> CustomerSelectList { get; set; }

        public IPurchaseProductService _purchaseProductService { get; set; }

        public PurchaseProductModel()
        {
            _purchaseProductService = Startup.AutofacContainer.Resolve<IPurchaseProductService>();
        }

        public async Task<object> GetAllAsync(DataTablesAjaxRequestModel tableModel)
        {
            var result = await _purchaseProductService.GetAllAsync(
                tableModel.SearchText,
                tableModel.GetSortText(new string[] { "orderDate", "productName", "customerName" }),
                tableModel.PageIndex, tableModel.PageSize);

            return new
            {
                recordsTotal = result.Total,
                recordsFiltered = result.TotalDisplay,
                data = (from item in result.Items
                        select new string[]
                        {
                                    item.OrderDate.ToString("dd MMMM, yyyy"),
                                    item.Product.Name,
                                    item.Customer.Name,
                                    item.IsPaymentComplete.ToString(),
                                    (item.ProductId.ToString() + "," + item.CustomerId.ToString())
                        }
                        ).ToArray()

            };
        }

        public async Task LoadByIdAsync(string id)
        {
            var productId = Convert.ToInt32(id.Split(',')[0]);
            var customerId = Convert.ToInt32(id.Split(',')[1]);

            var result = await _purchaseProductService.GetByIdAsync(productId, customerId);
            this.ProductId = result.ProductId;
            this.CustomerId = result.CustomerId;
            this.OrderDate = result.OrderDate;
            this.IsPaymentComplete = result.IsPaymentComplete;
        }

        public async Task LoadAllSelectListAsync()
        {
            this.ProductSelectList = await _purchaseProductService.GetProductsForSelectAsync();
            this.CustomerSelectList = await _purchaseProductService.GetProductsForSelectAsync();
        }

        public async Task AddOrUpdateAsync()
        {
            var entity = new PurchaseProduct
            {
                ProductId = this.ProductId,
                CustomerId = this.CustomerId,
                OrderDate = this.OrderDate.Value,
                IsPaymentComplete = this.IsPaymentComplete
            };
            var isExists = await _purchaseProductService.IsExistsAsync(entity.ProductId, entity.CustomerId);

            if (isExists) await _purchaseProductService.UpdateAsync(entity);
            else await _purchaseProductService.AddAsync(entity);
        }

        public async Task DeleteAsync(string id)
        {
            var productId = Convert.ToInt32(id.Split(',')[0]);
            var customerId = Convert.ToInt32(id.Split(',')[1]);

            await _purchaseProductService.DeleteAsync(productId, customerId);
        }
    }
}
