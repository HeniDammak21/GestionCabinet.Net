using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string nomPat { get; set; }
        public string prenomPat { get; set; }
        public string sexe { get; set; }
        public string adrPat { get; set; }
        public virtual ICollection<Consultation> Consultations { get; set; }
        public virtual ICollection<Rendezvous> Rendezvous { get; set; }
    }
}
