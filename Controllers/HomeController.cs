using Microsoft.AspNetCore.Mvc;

namespace StaticHttpContextAccessorExample.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ActiveUser.GetActiveUserInfo();

        return View();
    }

    public IActionResult Privacy()
    {
        ActiveUser.GetActiveUserInfo();

        return View();
    }
}
