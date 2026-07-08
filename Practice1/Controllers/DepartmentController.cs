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
    public class DepartmentController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetDept() => Ok(new Department(10, "Research & Dev", new() { "Dara", "Cheata", "Bona" }));
    }
}
/*
    ចូរបង្កើត Class Model មួយឈ្មោះ Department មាន Properties: Id, Name, និង Employees 
    (List of strings)។ នៅក្នុង DepartmentController ត្រូវបង្កើត Action Method មួយ បង្កើត Object 
    របស់ Department នេះ (ដែលមានបញ្ចូលឈ្មោះបុគ្គលិក ៣ នាក់) រួចបញ្ជូនជាទម្រង់ JSON Object ដែលមាន
    ផ្ទុកបញ្ជីឈ្មោះបុគ្គលិកនៅផ្នែកខាងក្នុង។
*/