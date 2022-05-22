using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmacyWebAPI.Models
{
    public class Medicament
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdMedicament { get; set; }
        [Required, MaxLength(150)]
        public string Name { get; set; }
        [Required, MaxLength(255)]
        public string Description { get; set; }
        [Required, MaxLength(150)]
        public string Type { get; set; }

        public virtual ICollection<Prescription> Prescritpions { get; set; }

    }
}
