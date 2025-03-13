using cnpm.Helpers;
using Microsoft.AspNetCore.Mvc;
namespace cnpm.Controllers
{
    [AuthHelper("Admin", "Employee")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            // Chỉ Admin mới vào được
            return View();
        }

        // ...
    }
}
