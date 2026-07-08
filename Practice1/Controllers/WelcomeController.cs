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
    public class WelcomeController : Controller
    {
        [HttpGet]
        public IActionResult GetMessage() => Ok("Welcome to ASP.NET Core Web API!");
        /*
            ចូរសរសេរ API Controller ថ្មីមួយឈ្មោះ WelcomeController ដែលមាន 
            Action Method មួយឈ្មោះ GetMessage() បញ្ជូនសារ "Welcome to ASP.NET Core Web API!"
            ត្រឡប់ទៅ Client វិញជា String (Status 200 OK)។
        */
    }
}