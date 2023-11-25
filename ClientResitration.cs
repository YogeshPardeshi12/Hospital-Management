using Microsoft.AspNetCore.Mvc;

namespace HospitalWebApp.Controllers
{
    public class ClientResitration : Controller
    {
        public IActionResult ClientView()
        {
            return View();
        }
    }
}
