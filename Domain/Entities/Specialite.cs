using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Specialite
    {
        public int SpecialiteID { get; set; }
        public string nomSpec { get; set; }
        public virtual ICollection<Medecin> Medecins{ get; set; }

    }
}
