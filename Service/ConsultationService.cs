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
    public class ConsultationService
    {
        private readonly GestionCabinetContext _context;

        public ConsultationService(GestionCabinetContext context)
        {
            _context = context;
        }

        public List<Consultation> GetAllConsultations()
        {
            return _context.Consultations.ToList();
        }

        public Consultation GetConsultationById(int ConsultationID)
        {
            return _context.Consultations.Find(ConsultationID);
        }

        public void AddConsultation(Consultation consultation)
        {
            _context.Consultations.Add(consultation);
            _context.SaveChanges();
        }



        public void UpdateConsultation(Consultation consultation)
        {
            _context.Entry(consultation).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteConsultation(int ConsultationID)
        {
            var consultation = _context.Consultations.Find(ConsultationID);
            if (consultation != null)
            {
                _context.Consultations.Remove(consultation);
                _context.SaveChanges();
            }
        }
    }
}

