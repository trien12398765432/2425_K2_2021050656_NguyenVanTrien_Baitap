using Microsoft.AspNetCore.Mvc;

namespace NguyenVanTrien.Controllers
{
public class EmployeeController : Controller
{
              // GET: /Employee/
        public IActionResult Index()
        {
            return View();
        }
        // GET: /Employee/Welcome/ 

        public string Welcome()
        {
            return "Welcome to NamDinh11";
        }
}
}