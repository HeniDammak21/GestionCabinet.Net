namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adreMed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Medecins", "adreMed", c => c.String());
            DropColumn("dbo.Medecins", "adrMed");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Medecins", "adrMed", c => c.String());
            DropColumn("dbo.Medecins", "adreMed");
        }
    }
}
