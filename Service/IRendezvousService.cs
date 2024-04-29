using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    interface IRendezvousService
    {
        List<Rendezvous> GetAllRendezvous();
        Rendezvous GetRendezvousById(int RendezvousID);
        void AddRendezvous(Rendezvous rendezvous);
        void UpdateRendezvous(Rendezvous rendezvous);
        void DeleteRendezvous(int RendezvousID);
    }
}
