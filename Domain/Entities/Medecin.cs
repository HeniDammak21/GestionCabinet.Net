using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Medecin
    {
        public int MedecinID { get; set; }
        public string nomMed { get; set; }
        public string prenomMed { get; set; }
        public string adreMed { get; set; }
        public int numTel { get; set; }
        public int SpecialiteID { get; set; }
        public Specialite Specialite { get; set; }
        public virtual ICollection<Rendezvous> Rendezvous { get; set; }

    }
}
