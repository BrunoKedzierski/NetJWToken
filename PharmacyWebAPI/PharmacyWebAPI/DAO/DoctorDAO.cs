using PharmacyWebAPI.Models;

namespace PharmacyWebAPI.NewFolder
{
    public class DoctorDAO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailName { get; set; }

        public Doctor MapToEntity() {

            return new Doctor { FirstName = this.FirstName, LastName = this.LastName, EmailName = this.EmailName };
        
        
        }
    }
}
