using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;

namespace NguyenVanTrien.Controllers
{
public class HelloWordController : Controller
{
            // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "Welcome to NamDinh";
        }

}
}