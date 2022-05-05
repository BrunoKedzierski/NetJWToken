using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pharmacy.Entities
{
    public class PrescriptionMedicament
    {
        public int IdMedicament { get; set; }
        public int IdPrescription { get; set; }
        public int Dose { get; set; }

        public virtual Medicament IdMedicamentNavigation { get; set; }
        public virtual Prescription IdPrescriptionNavigation { get; set; }

    }
}
