using Microsoft.AspNetCore.Mvc;

namespace Sistrategia.Hatchery.WebApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() {
        //return View();
        return View("Welcome");
    }

    public IActionResult Welcome() {
        return View();
    }
}
