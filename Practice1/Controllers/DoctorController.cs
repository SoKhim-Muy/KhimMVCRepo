using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practice1.Models;

namespace Practice1.Controllers
{
    [ApiController] [Route("api/[controller]")]
    public class DoctorController : ControllerBase {
        [HttpGet]
        public IActionResult GetDoctor() => Ok(new Doctor(1, "Dr. Sok Lim", "Cardiology"));
    }
}
/*
    ចូរបង្កើត Class Model មួយឈ្មោះ Doctor មាន Properties: Id, Name, Specialty 
    និង Constructor ផ្ដល់តម្លៃដំបូង។ បន្ទាប់មកបង្កើត DoctorController ដែលមាន Action Method 
    មួយ បង្កើត Object របស់ Doctor នេះ រួចបញ្ជូនជាទម្រង់ JSON ត្រឡប់ទៅ Client។
*/