using LeaveManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Student",
                DateOfBirth = new DateTime(1992,07,12)
            };
            return View(data);
        }
    }
}
