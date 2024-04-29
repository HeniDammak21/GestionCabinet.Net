using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Rendezvous
    {
        public int RendezvousID { get; set; }
        public string dateRdv { get; set; }
        public int PatientID { get; set; }
        public Patient Patient { get; set; }

        public int MedecinID { get; set; }
        public Medecin Medecin { get; set; }
    }
}
