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
    public class ColorController : Controller
    {
       [HttpGet]
        public IActionResult GetColors() => Ok(new List<string> { "Red", "Blue", "Green", "Yellow" });
    }
}
/*
    ចូរសរសេរ Action Method មួយឈ្មោះ GetColors() នៅក្នុង ColorController ដែលប្រកាសបញ្ជីពណ៌ 
    (List of strings) រួមមាន "Red", "Blue", "Green", "Yellow" រួចបញ្ជូនទិន្នន័យបញ្ជីពណ៌ទាំងនោះជាទម្រង់ 
    JSON Array (Status 200 OK)។
*/