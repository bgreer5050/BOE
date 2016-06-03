namespace BOE.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OriginalCode = c.String(),
                        Code = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Qualifications", "Job_Id", c => c.Int());
            CreateIndex("dbo.Qualifications", "Job_Id");
            AddForeignKey("dbo.Qualifications", "Job_Id", "dbo.Jobs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Qualifications", "Job_Id", "dbo.Jobs");
            DropIndex("dbo.Qualifications", new[] { "Job_Id" });
            DropColumn("dbo.Qualifications", "Job_Id");
            DropTable("dbo.Jobs");
        }
    }
}
