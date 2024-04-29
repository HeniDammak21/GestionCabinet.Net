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
 
    public class SpecialiteService : ISpecialiteService
    {
        private readonly GestionCabinetContext _context;

        public SpecialiteService(GestionCabinetContext context)
        {
            _context = context;
        }

        public List<Specialite> GetAllSepecialites()
        {
            return _context.Specialites.ToList();
        }

        public Specialite GetSpecialiteById(int idSpec)
        {
            return _context.Specialites.Find(idSpec);
        }

        public void AddSpecilaite(Specialite specialite)
        {
            _context.Specialites.Add(specialite);
            _context.SaveChanges();
        }

       

        public void UpdateSpecilaite(Specialite specialite)
        {
            _context.Entry(specialite).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteSpecilaite(int idSpec)
        {
            var specialite = _context.Specialites.Find(idSpec);
            if (specialite != null)
            {
                _context.Specialites.Remove(specialite);
                _context.SaveChanges();
            }
        }
    }
}
