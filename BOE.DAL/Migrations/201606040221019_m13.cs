namespace BOE.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m13 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Qualifications", "Status", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Qualifications", "Status");
        }
    }
}
