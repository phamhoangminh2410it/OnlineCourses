using Microsoft.AspNetCore.Mvc;

namespace OnlineCourses.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
