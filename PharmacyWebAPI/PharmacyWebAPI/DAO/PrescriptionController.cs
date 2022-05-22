using Microsoft.AspNetCore.Mvc;

namespace PharmacyWebAPI.DAO
{
    public class PrescriptionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
