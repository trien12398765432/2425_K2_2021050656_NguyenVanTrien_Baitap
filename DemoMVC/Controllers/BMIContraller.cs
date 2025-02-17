using Microsoft.AspNetCore.Mvc;

public class BMIController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(float chiều cao, float cân nặngnặng)
    {
        var model = new BMIModel { chiều cao = height, cân nặngnặng = weight };
        model.CalculateBMI();
        ViewBag.BMI = model.BMI;
        ViewBag.Category = model.Category;
        return View();
    }
}
