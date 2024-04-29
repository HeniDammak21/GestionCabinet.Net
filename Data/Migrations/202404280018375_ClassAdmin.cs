namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClassAdmin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administrateurs",
                c => new
                    {
                        AdministrateurID = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        MotDePasse = c.String(),
                    })
                .PrimaryKey(t => t.AdministrateurID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Administrateurs");
        }
    }
}
