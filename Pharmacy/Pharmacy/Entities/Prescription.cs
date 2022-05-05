using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pharmacy.Entities
{
    public class Prescription
    {
        public int IdPrescription { get; set; }
        public DateTime Date { get; set; }

        public ICollection<PrescriptionMedicament> PrescriptionsMedicaments { get; set; }


        public Prescription() {

            PrescriptionsMedicaments = new HashSet<PrescriptionMedicament>();
        
        }
    }
}
