using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    interface IMedecinService
    {
        List<Medecin> GetAllMedecins();
        Medecin GetMedecinById(int MedecinID);
        void AddMedecin(Medecin medecin);
        void UpdateMedecin(Medecin medecin);
        void DeleteMedecin(int MedecinID);
    }
}
