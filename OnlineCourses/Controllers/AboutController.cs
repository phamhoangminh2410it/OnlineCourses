using Microsoft.AspNetCore.Mvc;

namespace OnlineCourses.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
