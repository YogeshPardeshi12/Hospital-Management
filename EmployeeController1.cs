using Microsoft.AspNetCore.Mvc;

namespace HospitalWebApp.Controllers
{
    public class EmployeeController1 : Controller
    {
        public IActionResult Employee()
        {
            return View();
        }
    }
}
