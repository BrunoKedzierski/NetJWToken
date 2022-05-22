using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmacyWebAPI.Models
{
    public class Patient

    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdPatient { get; set; }
        [Required]
        [MaxLength(150)]
        public string FirstName { get; set; }
        [Required, MaxLength(150)]
        public string LastName { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        public DateTime BrithDate { get; set; }
    }
}
