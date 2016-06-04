namespace BOE.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m14 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Educations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AS400Code = c.String(),
                        Code = c.String(),
                        Description = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EducationLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                        StausDate = c.DateTime(nullable: false),
                        Notes = c.String(),
                        Education_Id = c.Int(),
                        Employee_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Educations", t => t.Education_Id)
                .ForeignKey("dbo.Employees", t => t.Employee_Id)
                .Index(t => t.Education_Id)
                .Index(t => t.Employee_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EducationLogs", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.EducationLogs", "Education_Id", "dbo.Educations");
            DropIndex("dbo.EducationLogs", new[] { "Employee_Id" });
            DropIndex("dbo.EducationLogs", new[] { "Education_Id" });
            DropTable("dbo.EducationLogs");
            DropTable("dbo.Educations");
        }
    }
}
