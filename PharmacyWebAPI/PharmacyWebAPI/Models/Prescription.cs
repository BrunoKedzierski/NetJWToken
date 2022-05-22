using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmacyWebAPI.Models
{
    public class Prescription
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPrescription { get; set; }
        [Required, Column(TypeName = "Date")]
        public DateTime Date { get; set; }
        [Required, Column(TypeName = "Date")]
        public DateTime DueDate { get; set; }
        public virtual Patient patient { get; set; }
        public virtual Doctor doctor { get; set; }

        public virtual ICollection<Medicament> Medicaments { get; set; }


    }
}
