using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    interface IPatientService
    {
        List<Patient> GetAllSPatients();
        Patient GetPatientById(int PatientID);
        void AddPatient(Patient patient);
        void UpdatePatient(Patient patient);
        void DeletePatient(int PatientID);
    }
}
