using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SchoolWeb.Controllers
{
    [Route("[controller]")]
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            // ស្តុកទិន្នន័យទៅក្នុង ViewBag មុននឹងបញ្ជូនទៅ View
            ViewBag.CompanyName = "Tech Angkor Co., Ltd";
            ViewBag.Address = "ក្រុងសៀមរាប, កម្ពុជា";
            ViewBag.Phone = "012 345 678";
            
            return View(); // បញ្ជូនទៅកាន់ឯកសារ Index.cshtml
        }
    }
}