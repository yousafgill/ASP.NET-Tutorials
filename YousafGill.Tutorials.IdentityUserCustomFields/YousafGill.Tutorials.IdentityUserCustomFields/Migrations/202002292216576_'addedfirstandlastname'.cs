namespace YousafGill.Tutorials.IdentityUserCustomFields.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedfirstandlastname : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}
