using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchoolApp.Models;

namespace SchoolWeb.Controllers
{
    [Route("[controller]")]
    public class BookController : Controller
    {
        public IActionResult Detail()
        {
            // បង្កើត Object និងដាក់តម្លៃ
            Book myBook = new Book { Id = 101, Title = "C# Programming", Price = 25.50m };
            
            // បញ្ជូន Object ជា Strongly-typed model ទៅកាន់ View
            return View(myBook);
            /*
                ចូរបង្កើត Class Model Book។ ក្នុង Controller បង្កើត Object សៀវភៅមួយក្បាល 
                រួចបញ្ជូនវាជាលក្ខណៈ Strongly-typed ទៅកាន់ View ដើម្បីបង្ហាញក្នុងទម្រង់ Card របស់ Bootstrap។ 
            */
        }
    }
}