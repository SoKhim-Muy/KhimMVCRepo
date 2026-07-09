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
    [Route("api/search")]
    public class SearchApiController : ControllerBase
    {
        [HttpGet("{id}")] // URL: api/search/1 , api/search/5 ...
        public IActionResult GetUserById(int id)
        {
            // ក្លែងធ្វើការស្វែងរកក្នុង Database
            if (id == 1)
            {
                var user = new { Id = 1, Name = "Lim", Role = "Admin" };
                return Ok(user); // ជោគជ័យ 200 OK
            }
            else
            {
                // បរាជ័យ 404 រួមជាមួយសារបញ្ជាក់
                return NotFound(new { message = $"សុំទោស រកមិនឃើញទិន្នន័យលេខ ID: {id} ឡើយ" }); 
            }
        }
    }
}
/*
    ចូរបង្កើត API Endpoint ដែលទទួលយកប៉ារ៉ាម៉ែត្រ id ពី URL។ បើ id ស្មើនឹង ១ ត្រូវបញ្ចេញព័ត៌មានអ្នកប្រើប្រាស់, 
    បើមិនមែនទេ ត្រូវបញ្ចេញសារថា "រកមិនឃើញ" (HTTP Status 404)។ 
*/