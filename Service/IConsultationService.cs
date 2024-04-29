using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    interface IConsultationService
    {
        List<Consultation> GetAllConsultations();
        Consultation GetConsultationById(int ConsultationID);
        void AddConsultation(Consultation consultation);
        void UpdateConsultation(Consultation consultation);
        void DeleteConsultation(int ConsultationID);
    }
}
