using Microsoft.AspNetCore.Mvc;

namespace CodingKata.Services.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
