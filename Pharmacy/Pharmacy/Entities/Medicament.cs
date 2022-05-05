using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pharmacy.Entities
{
    public class Medicament
    {
    
        public int IdMedicament { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Type { get; set; }
        
        public virtual ICollection<PrescriptionMedicament> MedicamentPrescriptions { get; set; }


        public Medicament() {


            MedicamentPrescriptions = new HashSet<PrescriptionMedicament>();
        
        
        }
    }
}
