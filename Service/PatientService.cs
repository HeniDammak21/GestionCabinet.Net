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
    public class PatientService
    {
        private readonly GestionCabinetContext _context;

        public PatientService(GestionCabinetContext context)
        {
            _context = context;
        }

        public List<Patient> GetAllSPatients()
        {
            return _context.Patients.ToList();
        }

        public Patient GetPatientById(int PatientID)
        {
            return _context.Patients.Find(PatientID);
        }

        public void AddPatient(Patient patient)
        {
            _context.Patients.Add(patient);
            _context.SaveChanges();
        }



        public void UpdatePatient(Patient patient)
        {
            _context.Entry(patient).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeletePatient(int PatientID)
        {
            var patient = _context.Patients.Find(PatientID);
            if (patient != null)
            {
                _context.Patients.Remove(patient);
                _context.SaveChanges();
            }
        }
    }
}
