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
    public class CustomerModel : AdminBaseModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? BranchName { get; set; }

        public ICustomerService _customerService { get; set; }

        public CustomerModel()
        {
            _customerService = Startup.AutofacContainer.Resolve<ICustomerService>();
        }

        public async Task<object> GetAllAsync(DataTablesAjaxRequestModel tableModel)
        {
            var result = await _customerService.GetAllAsync(
                tableModel.SearchText,
                tableModel.GetSortText(new string[] { "name", "phonenumber", "email", "branchname" }),
                tableModel.PageIndex, tableModel.PageSize);

            return new
            {
                recordsTotal = result.Total,
                recordsFiltered = result.TotalDisplay,
                data = (from item in result.Items
                        select new string[]
                        {

                                    item.Name,
                                    item.PhoneNumber,
                                    item.Email,
                                    item.BranchName,
                                    item.Id.ToString()
                        }
                        ).ToArray()

            };
        }

        public async Task LoadByIdAsync(int id)
        {
            var result = await _customerService.GetByIdAsync(id);
            this.Id = result.Id;
            this.Name = result.Name;
            this.PhoneNumber = result.PhoneNumber;
            this.BranchName = result.BranchName;
        }

        public async Task AddAsync()
        {
            var entity = new Customer { Name = this.Name, PhoneNumber = this.PhoneNumber, Email = this.Email };
            await _customerService.AddAsync(entity);
        }

        public async Task UpdateAsync()
        {
            var entity = new Customer { Id = this.Id, Name = this.Name, PhoneNumber = this.PhoneNumber, Email = this.Email };
            await _customerService.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _customerService.DeleteAsync(id);
        }
    }
}
