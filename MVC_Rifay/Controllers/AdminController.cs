using Microsoft.AspNetCore.Mvc;

namespace MVC_Rifay.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
