namespace BOE.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m12 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AttendanceIncident",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Points = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OriginalCode = c.String(),
                        Code = c.String(),
                        Description = c.String(),
                        Comments = c.String(),
                        Employee_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employee_Id)
                .Index(t => t.Employee_Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClockNo = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        TerminationDate = c.DateTime(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Qualifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Employee_Id = c.Int(),
                        Job_Id = c.Int(),
                        HourlyEmployee_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employee_Id)
                .ForeignKey("dbo.Jobs", t => t.Job_Id)
                .ForeignKey("dbo.Employees", t => t.HourlyEmployee_Id)
                .Index(t => t.Employee_Id)
                .Index(t => t.Job_Id)
                .Index(t => t.HourlyEmployee_Id);
            
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
            
            CreateTable(
                "dbo.OtherIncidents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OriginalCode = c.String(),
                        Code = c.String(),
                        Description = c.String(),
                        Comments = c.String(),
                        Employee_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employee_Id)
                .Index(t => t.Employee_Id);
            
            CreateTable(
                "dbo.SafetyIncidents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OriginalCode = c.String(),
                        Code = c.String(),
                        Description = c.String(),
                        Comments = c.String(),
                        Employee_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employee_Id)
                .Index(t => t.Employee_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SafetyIncidents", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.OtherIncidents", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.AttendanceIncident", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.Qualifications", "HourlyEmployee_Id", "dbo.Employees");
            DropForeignKey("dbo.Qualifications", "Job_Id", "dbo.Jobs");
            DropForeignKey("dbo.Qualifications", "Employee_Id", "dbo.Employees");
            DropIndex("dbo.SafetyIncidents", new[] { "Employee_Id" });
            DropIndex("dbo.OtherIncidents", new[] { "Employee_Id" });
            DropIndex("dbo.Qualifications", new[] { "HourlyEmployee_Id" });
            DropIndex("dbo.Qualifications", new[] { "Job_Id" });
            DropIndex("dbo.Qualifications", new[] { "Employee_Id" });
            DropIndex("dbo.AttendanceIncident", new[] { "Employee_Id" });
            DropTable("dbo.SafetyIncidents");
            DropTable("dbo.OtherIncidents");
            DropTable("dbo.Jobs");
            DropTable("dbo.Qualifications");
            DropTable("dbo.Employees");
            DropTable("dbo.AttendanceIncident");
        }
    }
}
