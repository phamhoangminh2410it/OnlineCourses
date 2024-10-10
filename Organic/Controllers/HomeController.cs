using Microsoft.AspNetCore.Mvc;
using Organic.Models;

namespace Organic.Controllers;
public class HomeController : Controller
{
    OrganicContext context;
    public HomeController(OrganicContext context)
    {
        this.context = context;
    }
    public IActionResult Index()
    {
        ViewBag.Departments = context.Departments.ToList();

        ViewBag.Categories = context.Categories.ToList();
        return View(context.Products.ToList());
    }

}