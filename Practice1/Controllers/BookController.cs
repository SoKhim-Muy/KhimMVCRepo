using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Practice1.Controllers
{
    [ApiController] [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
       [HttpGet]
        public IActionResult GetBooks() => Ok(new List<Book> {
            new(1, "C# Programming", 25.00m), new(2, "ASP.NET Core API", 35.00m)
        });
    }
}
/*
    ចូរបង្កើត Class Model មួយឈ្មោះ Book មាន Properties: Id, Title, Author, Price។ នៅក្នុង 
    Book Class ត្រូវបង្កើត Method មួយឈ្មោះ GetDiscountedPrice() ដែលគណនាបញ្ចុះតម្លៃ ១០% លើតម្លៃសៀវភៅ។ 
    សរសេរ BookController បង្កើតបញ្ជីសៀវភៅ ៣ ក្បាល (Mock Data List) រួចបញ្ជូនទៅ Client ជាទម្រង់ JSON Array 
    ដែលមានផ្ទុកតម្លៃ Price ដើម និង DiscountedPrice គណនាភ្លាមៗ។
*/