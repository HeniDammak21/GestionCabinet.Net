using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    interface ISpecialiteService
    {
        List<Specialite> GetAllSepecialites();
        Specialite GetSpecialiteById(int idSpec);
        void AddSpecilaite(Specialite specialite);
        void UpdateSpecilaite(Specialite specialite);
        void DeleteSpecilaite(int idSpec);
    }
}
