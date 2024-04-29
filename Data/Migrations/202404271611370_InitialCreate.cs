namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Consultations",
                c => new
                    {
                        ConsultationID = c.Int(nullable: false, identity: true),
                        dateCons = c.String(),
                        recapCons = c.String(),
                        PatientID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ConsultationID)
                .ForeignKey("dbo.Patients", t => t.PatientID, cascadeDelete: true)
                .Index(t => t.PatientID);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientID = c.Int(nullable: false, identity: true),
                        nomPat = c.String(),
                        prenomPat = c.String(),
                        sexe = c.String(),
                        adrPat = c.String(),
                    })
                .PrimaryKey(t => t.PatientID);
            
            CreateTable(
                "dbo.Rendezvous",
                c => new
                    {
                        RendezvousID = c.Int(nullable: false, identity: true),
                        dateRdv = c.String(),
                        PatientID = c.Int(nullable: false),
                        MedecinID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RendezvousID)
                .ForeignKey("dbo.Medecins", t => t.MedecinID, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.PatientID, cascadeDelete: true)
                .Index(t => t.PatientID)
                .Index(t => t.MedecinID);
            
            CreateTable(
                "dbo.Medecins",
                c => new
                    {
                        MedecinID = c.Int(nullable: false, identity: true),
                        nomMed = c.String(),
                        prenomMed = c.String(),
                        adrMed = c.String(),
                        numTel = c.Int(nullable: false),
                        SpecialiteID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MedecinID)
                .ForeignKey("dbo.Specialites", t => t.SpecialiteID, cascadeDelete: true)
                .Index(t => t.SpecialiteID);
            
            CreateTable(
                "dbo.Specialites",
                c => new
                    {
                        SpecialiteID = c.Int(nullable: false, identity: true),
                        nomSpec = c.String(),
                    })
                .PrimaryKey(t => t.SpecialiteID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rendezvous", "PatientID", "dbo.Patients");
            DropForeignKey("dbo.Medecins", "SpecialiteID", "dbo.Specialites");
            DropForeignKey("dbo.Rendezvous", "MedecinID", "dbo.Medecins");
            DropForeignKey("dbo.Consultations", "PatientID", "dbo.Patients");
            DropIndex("dbo.Medecins", new[] { "SpecialiteID" });
            DropIndex("dbo.Rendezvous", new[] { "MedecinID" });
            DropIndex("dbo.Rendezvous", new[] { "PatientID" });
            DropIndex("dbo.Consultations", new[] { "PatientID" });
            DropTable("dbo.Specialites");
            DropTable("dbo.Medecins");
            DropTable("dbo.Rendezvous");
            DropTable("dbo.Patients");
            DropTable("dbo.Consultations");
        }
    }
}
