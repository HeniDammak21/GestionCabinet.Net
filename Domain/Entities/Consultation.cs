using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Consultation
    {
        public int ConsultationID { get; set; }
        public string dateCons { get; set; }
        public string recapCons { get; set; }
        public int PatientID { get; set; }
        public Patient Patient { get; set; }

    }
}
