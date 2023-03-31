using Microsoft.AspNetCore.Mvc;

namespace StaticHttpContextAccessorExample.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ActiveUser.GetActiveUserInfo();

        return View();
    }
}
