using Microsoft.AspNetCore.Mvc;

namespace HospitalWebApp.Controllers
{
    public class DepartmentController1 : Controller
    {
        public IActionResult Department()
        {
            return View();
        }
    }
}
