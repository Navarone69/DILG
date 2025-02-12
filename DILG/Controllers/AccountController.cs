using Microsoft.AspNetCore.Mvc;

namespace DILG.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
