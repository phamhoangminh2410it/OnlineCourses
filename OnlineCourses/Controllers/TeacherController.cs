using Microsoft.AspNetCore.Mvc;

namespace OnlineCourses.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
