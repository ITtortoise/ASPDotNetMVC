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
    public class ProductModel :AdminBaseModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public double? Price { get; set; }

        public IProductService _productService { get; set; }

        public ProductModel()
        {
            _productService = Startup.AutofacContainer.Resolve<IProductService>();
        }

        public async Task<object> GetAllAsync(DataTablesAjaxRequestModel tableModel)
        {
            var result = await _productService.GetAllAsync(
                tableModel.SearchText,
                tableModel.GetSortText(new string[] { "name", "description", "price" }),
                tableModel.PageIndex, tableModel.PageSize);

            return new
            {
                recordsTotal = result.Total,
                recordsFiltered = result.TotalDisplay,
                data = (from item in result.Items
                        select new string[]
                        {

                                    item.Name,
                                    item.Description,
                                    item.Price.ToString(),
                                    item.Id.ToString()
                        }
                        ).ToArray()

            };
        }

        public async Task LoadByIdAsync(int id)
        {
            var result = await _productService.GetByIdAsync(id);
            this.Id = result.Id;
            this.Name = result.Name;
            this.Description = result.Description;
            this.Price = result.Price;
        }

        public async Task AddAsync()
        {
            var entity = new Product { Name = this.Name, Description = this.Description, Price = this.Price.Value };
            await _productService.AddAsync(entity);
        }

        public async Task UpdateAsync()
        {
            var entity = new Product { Id = this.Id, Name = this.Name, Description = this.Description, Price = this.Price.Value };
            await _productService.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _productService.DeleteAsync(id);
        }
    }
}
