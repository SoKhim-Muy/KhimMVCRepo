using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace Practice1.Controllers
{
    [ApiController] [Route("api/[controller]")]
    public class PingController : Controller
    {
        [HttpGet]
        public IActionResult Ping() => Ok(new { status = "Healthy", timestamp = DateTime.Now });
        /*
            ចូរសរសេរ API Controller ថ្មីមួយឈ្មោះ PingController ដែលមាន Action Method មួយឈ្មោះ Ping() 
            បញ្ជូន JSON Object ត្រឡប់ទៅ Client វិញដែលមានផ្ទុកព័ត៌មាន status = "Healthy" និង 
            timestamp = [ពេលវេលាបច្ចុប្បន្ន]។
        */
    }
}