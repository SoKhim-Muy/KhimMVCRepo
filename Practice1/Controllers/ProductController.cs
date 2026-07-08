using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Practice1.Controllers
{
    [Route("[controller]")]
    public class ProductController : Controller
    {
        [Route("Details")]
        public IActionResult EmployeeDetails() {
            Employee emp = new(501, "Sok Lim", 1250.00m);
            return View(emp);
            /*
                ចូរបង្កើត Class Model មួយឈ្មោះ Employee មាន Properties: 
                Id, Name, Salary រួមជាមួយ Constructor សម្រាប់ចាប់ផ្ដើមតម្លៃ។ 
                នៅក្នុង Controller ត្រូវបង្កើត Object មួយចេញពី Class នេះ រួចបញ្ជូន
                ជាលក្ខណៈ Strongly-typed Model ទៅកាន់ View ដើម្បីបង្ហាញព័ត៌មានបុគ្គលិកនោះ។
            */
        }

        [Route("Invoice")]
        public IActionResult OrderInvoice() {
            Order myOrder = new(1005, DateTime.Now, new() { "ThinkPad X1", "Logitech Mouse", "USB-C Hub" });
            return View(myOrder);
            /*
                ចូរបង្កើត Class Model មួយឈ្មោះ Order ដែលមាន Properties: OrderId, 
                OrderDate (DateTime), និង Items (List of strings)។ នៅក្នុង Action 
                ត្រូវបង្កើត Object នៃ Order ដែលមានមុខទំនិញជាច្រើន រួចបញ្ជូនទៅកាន់ View 
                ដើម្បីបង្ហាញព័ត៌មានក្បាលវិក្កយបត្រ និងប្រើរង្វិលជុំ Razor ដើម្បីទាញបញ្ជីទំនិញមកបង្ហាញ។
            */
        }

        [Route("List")]
        public IActionResult StudentScoreList() {
            List<StudentScore> list = new() {
                new(1, "Dara SOK", 10, 30, 48), new(2, "Bona HENG", 9, 25, 34), new(3, "Srey OUN", 5, 12, 18)
            };
            return View(list);
            /*
                ចូរបង្កើត Class Model មួយឈ្មោះ StudentScore មាន Properties: 
                Id, Name, Attendance, Midterm, Final, រួមទាំង Method គណនាពិន្ទុសរុប 
                (Attendance + Midterm + Final) និង Method វិនិច្ឆ័យនិទ្ទេស (Grade A, B, C, D, F)។ 
                នៅក្នុង Action ត្រូវបង្កើតបញ្ជីសិស្ស ៣ នាក់ រួចបញ្ជូនទៅកាន់ View ដើម្បីបង្ហាញក្នុងតារាង 
                HTML និងលម្អិត Style (Bootstrap badges) ទៅតាមនិទ្ទេសនិមួយៗ។
            */
        }
    }
}