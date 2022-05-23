using Microsoft.AspNetCore.Mvc;
using PharmacyWebAPI.Models;

namespace PharmacyWebAPI.DAO
{

    [Route("api/[controller]")]
    [ApiController]
    public class PrescriptionsController : Controller
    {

        PharmacyDbContext _context;

        public PrescriptionsController(PharmacyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetPrescritpions()
        {
            var prescriptions = _context.Prescriptions;
            return Ok(prescriptions);
        }

        [HttpGet("{id}")]
        public IActionResult GetPrescritpion(int id)
        {
            var prescription = _context.Prescriptions.FirstOrDefault(p => p.IdPrescription == id);
            if (prescription == null)
                return BadRequest($"No prescription with id {id}");
            return Ok(prescription);
        }
    }
}
