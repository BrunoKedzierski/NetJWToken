using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmacyWebAPI.Models
{
    public class Doctor
    {
        
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       
        public int IdDoctor { get; set; }
        [Required]
        [MaxLength(150)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(150)]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailName { get; set; }

        public virtual ICollection<Prescription> prescriptions { get; set; }
        
    }
}
