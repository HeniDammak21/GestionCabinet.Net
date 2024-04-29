using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Administrateur
    {
        public int AdministrateurID { get; set; }
        public string UserName { get; set; }
        public string MotDePasse { get; set; }
    }
}
