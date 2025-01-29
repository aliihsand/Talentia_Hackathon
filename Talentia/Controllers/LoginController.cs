using Microsoft.AspNetCore.Mvc;

namespace Talentia.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
