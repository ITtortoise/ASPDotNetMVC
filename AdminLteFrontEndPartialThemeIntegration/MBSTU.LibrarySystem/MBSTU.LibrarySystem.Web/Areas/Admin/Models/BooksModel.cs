using MBSTU.Library.Framwork;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MBSTU.LibrarySystem.Web.Areas.Admin.Models
{
        public class BooksModel : AdminBaseModel
        {
            private readonly IBookService _bookService;
            public BooksModel(IConfiguration configuration)
            {
                _bookService = new BookService(configuration.GetConnectionString("DefaultConnection"));
            }

            internal object GetBooks(DataTablesAjaxRequestModel tableModel)
            {
                var data = _bookService.GetBooks(
                    tableModel.PageIndex,
                    tableModel.PageSize,
                    tableModel.SearchText,
                    tableModel.GetSortText(new string[] { "Title", "Author", "Edition", "PublicationDate" }));

                return new
                {
                    recordsTotal = data.total,
                    recordsFiltered = data.totalDisplay,
                    data = (from record in data.records
                            select new string[]
                            {
                                record.Title,
                                record.Author,
                                record.Edition,
                                record.PublicationDate.ToString()
                            }
                        ).ToArray()

                };
            }
        }
    }

