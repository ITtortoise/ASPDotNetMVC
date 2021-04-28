using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SendMailWithAttachmentAsp.netCoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SendMailWithAttachmentAsp.netCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly IWebHostEnvironment webHostEnvironment;
        public HomeController(IConfiguration _configuration, IWebHostEnvironment _webHostEnvironment)
        {
            configuration = _configuration;
            webHostEnvironment = _webHostEnvironment;
        }
       
        [HttpGet]
        public IActionResult Index()
        {
            return View("Index");
        }
        [HttpPost]
        public IActionResult Send(Contact contact,IFormFile[] attachments)
        {
            var body = "Name: " + contact.Name + "<br> Address " + contact.Address +
                "<br>Phone" + contact.Phone + "<br>";
            var mailHelper = new MailHelper(configuration);
            List<string> filesNames = null;
            if (attachments != null && attachments.Length > 0)
            {
                filesNames = new List<string>();
                foreach (IFormFile attachment in attachments)
                {
                    var path = Path.Combine(webHostEnvironment.WebRootPath, "uploads", attachment.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        attachment.CopyToAsync(stream);
                    }
                    filesNames.Add(path);
                }
            }

            if (mailHelper.Send(contact.Email, configuration["Gmail:Username"], contact.Subject, body, filesNames))
            {
                ViewBag.msg = "Sent Mail Successfully";
            }
            else
            {
                ViewBag.msg = "Falied";
            }

            return View("Index");
        }              
            
    }

}
