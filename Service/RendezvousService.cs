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
    public class RendezvousService
    {
        private readonly GestionCabinetContext _context;

        public RendezvousService(GestionCabinetContext context)
        {
            _context = context;
        }

        public List<Rendezvous> GetAllRendezvous()
        {
            return _context.Rendezvous.ToList();
        }

        public Rendezvous GetRendezvousById(int RendezvousID)
        {
            return _context.Rendezvous.Find(RendezvousID);
        }

        public void AddRendezvous(Rendezvous rendezvous)
        {
            _context.Rendezvous.Add(rendezvous);
            _context.SaveChanges();
        }



        public void UpdateRendezvous(Rendezvous rendezvous)
        {
            _context.Entry(rendezvous).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteRendezvous(int RendezvousID)
        {
            var rendezvous = _context.Rendezvous.Find(RendezvousID);
            if (rendezvous != null)
            {
                _context.Rendezvous.Remove(rendezvous);
                _context.SaveChanges();
            }
        }
    }
}
