using Microsoft.AspNetCore.Mvc;

namespace OnlineCourses.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
