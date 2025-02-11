using Microsoft.AspNetCore.Mvc;

namespace NguyenVanTrien.Controllers
{
public class PersonController : Controller
{
                // GET: /Person/
        public IActionResult Index()
        {
            return View();
        }
        // GET: /Person/Welcome/ 

        public string Welcome()
        {
            return "Welcome to NamDinh";
        }
}
}

namespace DemoMVC.Controllers
{
    public class PesonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Person psps)
        {
            string strOutput = "Xin Chào " + psps.PersonId + "-" + psps.FullName + "-" + psps.Address; 
            ViewBag.infoPerson = strOutput; 

            return View();
        }
    }
}