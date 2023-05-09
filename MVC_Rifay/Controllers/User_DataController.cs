using Microsoft.AspNetCore.Mvc;

namespace MVC_Rifay.Controllers
{
    public class User_DataController : Controller
    {
        public IActionResult Signup()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

    }
}
