using Microsoft.AspNetCore.Mvc;

namespace Sistrategia.Hatchery.WebApp.Controllers;

public class AccountController : Controller
{
    public IActionResult Login() {
        return View();
    }

    public IActionResult Register() {
        return View();
    }
}
