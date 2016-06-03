namespace BOE.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "LastName");
        }
    }
}
