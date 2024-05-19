using Data;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class MedecinService : IMedecinService
    {
        private readonly GestionCabinetContext _context;

        public MedecinService(GestionCabinetContext context)
        {
            _context = context;
        }

        public List<Medecin> GetAllMedecins()
        {
            return _context.Medecins.ToList();
        }

        public Medecin GetMedecinById(int MedecinID)
        {
            return _context.Medecins.Find(MedecinID);
        }

        public void AddMedecin(Medecin medecin)
        {
            _context.Medecins.Add(medecin);
            _context.SaveChanges();
        }



        public void UpdateMedecin(Medecin medecin)
        {
            _context.Entry(medecin).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteMedecin(int MedecinID)
        {
            var medecin = _context.Medecins.Find(MedecinID);
            if (medecin != null)
            {
                _context.Medecins.Remove(medecin);
                _context.SaveChanges();
            }
        }
    }
}
