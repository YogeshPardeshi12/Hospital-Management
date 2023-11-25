using Microsoft.AspNetCore.Mvc;

namespace HospitalWebApp.Controllers
{
    public class HospitalController1 : Controller
    {
        public IActionResult Hospital()
        {
            return View();
        }
    }
}
