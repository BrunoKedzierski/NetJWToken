using Microsoft.AspNetCore.Mvc;
using PharmacyWebAPI.Models;
using PharmacyWebAPI.NewFolder;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PharmacyWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {



        
        PharmacyDbContext _context;

        public DoctorsController(PharmacyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetDoctors()
        {
            var doctors = _context.Doctors;

            return Ok(doctors);
        }
         
     

        [HttpPost]
        public IActionResult PostDoctor([FromBody] DoctorDAO doctor)
        {
           
            _context.Doctors.Add(doctor.MapToEntity());
            _context.SaveChanges();
            return Ok();
        }

      
        [HttpPut("{id}")]
        public IActionResult PutDoctor(int id, [FromBody] DoctorDAO doctor)
        {
            Doctor doc = _context.Doctors.FirstOrDefault(d => d.IdDoctor == id);
            if (doc == null)
                return BadRequest($"No doctor with id {id}");
            doc = doctor.MapToEntity();
            _context.Update(doc);
            _context.SaveChanges();
            return Ok();

        }

       
        [HttpDelete("{id}")]
        public IActionResult DeleteDoctor(int id)
        {
            Doctor doc = _context.Doctors.FirstOrDefault(d => d.IdDoctor == id);
            if (doc == null)
                return BadRequest($"No doctor with id {id}");
            _context.Doctors.Remove(doc);
            _context.SaveChanges();
            return Ok();
        }
    }
}
