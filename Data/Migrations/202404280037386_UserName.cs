namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Administrateurs", "UserName", c => c.String());
            DropColumn("dbo.Administrateurs", "Login");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Administrateurs", "Login", c => c.String());
            DropColumn("dbo.Administrateurs", "UserName");
        }
    }
}
