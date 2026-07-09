using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SchoolWeb.Controllers
{
    public class Subject {
        public string Code { get; set; }
        public string Title { get; set; }
    }

    [ApiController]
    [Route("api/subjects")] // កំណត់ Route ផ្ទាល់ខ្លួន ដោយមិនប្រើ [controller]
    public class SubjectApiController : ControllerBase
    {
        [HttpGet("all")] // URL ពេញ: api/subjects/all
        public IActionResult GetAllSubjects()
        {
            List<Subject> list = new List<Subject>
            {
                new Subject { Code = "CS101", Title = "Programming C#" },
                new Subject { Code = "DB201", Title = "SQL Server" }
            };
            
            return Ok(list);
        }
    }
}
/*
    ចូរបង្កើត API ដើម្បីបញ្ចេញបញ្ជីឈ្មោះមុខវិជ្ជា (List of Objects) ជាទម្រង់ JSON Array 
    សម្រាប់ឱ្យកម្មវិធី Mobile App ទាញយកទៅប្រើ។ កំណត់ URL Endpoint ជា api/subjects/all។ 
*/