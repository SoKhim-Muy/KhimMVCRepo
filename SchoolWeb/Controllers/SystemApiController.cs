using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SchoolWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // ស្មើនឹង api/systemapi
    public class SystemApiController : ControllerBase
    {
        [HttpGet("status")] // URL បូកបញ្ចូលគ្នា: api/systemapi/status
        public IActionResult GetStatus()
        {
            // បង្កើត Anonymous Object ក្លែងទិន្នន័យ Server
            var serverInfo = new {
                Status = "Online & Running",
                Version = "1.0.5",
                TimeChecked = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            };
            return Ok(serverInfo); // ត្រឡប់ Status 200 រួមជាមួយទិន្នន័យ
        }
    }
}
/*
    ចូរបង្កើត API Controller ដើម្បីបញ្ចេញទិន្នន័យទូទៅរបស់ម៉ាស៊ីនមេ (ជា Anonymous Object) 
    ទៅឱ្យ Client នៅពេលគេហៅ URL: api/systemapi/status។ 
*/