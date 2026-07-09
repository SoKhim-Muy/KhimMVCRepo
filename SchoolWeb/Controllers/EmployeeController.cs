using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SchoolWeb.Controllers
{
    public class Employee { public string Name {get;set;} public string Position {get;set;} }
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult List()
        {
            // បង្កើត Collection នៃបុគ្គលិក
            List<Employee> staffs = new List<Employee>() {
                new Employee { Name = "Sok Dara", Position = "Manager" },
                new Employee { Name = "Sao Chea", Position = "Developer" },
                new Employee { Name = "Keo Tola", Position = "Designer" }
            };
            return View(staffs); // បញ្ជូន List ទៅ View
        }
    }
}
/*
    ដើម្បីជៀសវាងការសរសេរកូដ HTML (Head, Body, Bootstrap Link) ដដែលៗ គ្រប់ទំព័រ ចូរបង្កើត Master Page 
    (_Layout.cshtml) និងភ្ជាប់វាជាមួយ _ViewStart.cshtml។ បន្ទាប់មកបង្កើត Controller ដើម្បីបញ្ជូន List<Employee> 
    ទៅកាន់ View និងប្រើ @foreach បង្ហាញជាតារាង។ 
*/