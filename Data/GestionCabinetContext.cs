using Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Data
{
    public partial class GestionCabinetContext : DbContext
    {
        public GestionCabinetContext()
            : base("name=GestionCabinetContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Rendezvous> Rendezvous { get; set; }
        public DbSet<Medecin> Medecins { get; set; }
        public DbSet<Consultation> Consultations { get; set; }
        public DbSet<Specialite> Specialites { get; set; }
        public DbSet<Administrateur> Administrateurs { get; set; }





    }
}
