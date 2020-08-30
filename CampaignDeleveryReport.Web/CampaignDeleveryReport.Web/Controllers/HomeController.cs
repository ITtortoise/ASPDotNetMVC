using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CampaignDeleveryReport.Web.Models;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace CampaignDeleveryReport.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            

           
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
           // using (var package = new ExcelPackage(new FileInfo("MyWorkbook.xlsx")))
                byte[] fileContents;
            using (var package = new ExcelPackage())
            {
                var workSheet = package.Workbook.Worksheets.Add("Sheet");
      
                workSheet.Cells[1, 1].Value = "MailDelevered";
                workSheet.Cells[1, 1].Style.Font.Size = 12;
                workSheet.Cells[1, 1].Style.Font.Bold = true;
                workSheet.Cells[1, 1].Style.Border.Top.Style = ExcelBorderStyle.Hair;

           
                workSheet.Cells[1, 2].Value = "MailNotDelevered";
                workSheet.Cells[1, 2].Style.Font.Size = 12;
                workSheet.Cells[1, 2].Style.Font.Bold = true;
                workSheet.Cells[1, 2].Style.Border.Top.Style = ExcelBorderStyle.Hair;

                workSheet.Cells[2, 1].Value = "Rabbi@gmail.com";
                workSheet.Cells[2, 1].Style.Font.Size = 12;
                workSheet.Cells[2, 1].Style.Border.Top.Style = ExcelBorderStyle.Hair;
                workSheet.Cells[3, 1].Value = "Nahid@gmail.com";
                workSheet.Cells[3, 1].Style.Font.Size = 12;
                workSheet.Cells[3, 1].Style.Border.Top.Style = ExcelBorderStyle.Hair;
                workSheet.Cells[4, 1].Value = "Atik@gmail.com";
                workSheet.Cells[4, 1].Style.Font.Size = 12;
                workSheet.Cells[4, 1].Style.Border.Top.Style = ExcelBorderStyle.Hair;

               
                workSheet.Cells[2, 2].Value = "Sunon@gmail.com";
                workSheet.Cells[2, 2].Style.Font.Size = 12;
                workSheet.Cells[2, 2].Style.Border.Top.Style = ExcelBorderStyle.Hair;
                workSheet.Cells[3, 2].Value = "Hasan@gmail.com";
                workSheet.Cells[3, 2].Style.Font.Size = 12;
                workSheet.Cells[3, 2].Style.Border.Top.Style = ExcelBorderStyle.Hair;
                workSheet.Cells[4, 2].Value = "Faizal@gmail.com";
                workSheet.Cells[4, 2].Style.Font.Size = 12;
                workSheet.Cells[4, 2].Style.Border.Top.Style = ExcelBorderStyle.Hair;


                fileContents = package.GetAsByteArray();
            }

            if(fileContents == null || fileContents.Length == 0)
            {
                return NotFound();
            }

            return File(
                fileContents: fileContents,
                Response.ContentType = "application/vnd.xlsx",
                fileDownloadName : "MailDeleveryReport.xlsx"
                ) ;
            
            

           
        }

    }
}