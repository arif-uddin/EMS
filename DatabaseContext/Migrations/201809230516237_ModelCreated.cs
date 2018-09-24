namespace DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Option = c.String(nullable: false),
                        CorrectAns = c.Boolean(nullable: false),
                        QuestionId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questions", t => t.QuestionId, cascadeDelete: true)
                .Index(t => t.QuestionId);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Q = c.String(),
                        OptionType = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Batches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BatchNo = c.Int(nullable: false),
                        Description = c.String(),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CourseId = c.Int(nullable: false),
                        Trainer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Trainers", t => t.Trainer_Id)
                .Index(t => t.BatchNo, unique: true)
                .Index(t => t.CourseId)
                .Index(t => t.Trainer_Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Outline = c.String(),
                        Credit = c.Int(nullable: false),
                        Duration = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Organizations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        Address = c.String(),
                        ContactNo = c.Long(nullable: false),
                        About = c.String(),
                        Logo = c.Byte(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        tag = c.String(),
                        CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .Index(t => t.CourseId);
            
            CreateTable(
                "dbo.Participants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        RegNo = c.String(),
                        ContactNo = c.String(),
                        Email = c.String(),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        City = c.String(),
                        PostalCode = c.Int(nullable: false),
                        Country = c.String(),
                        Profession = c.String(),
                        HighestAcademicQualification = c.String(),
                        Image = c.Byte(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        BatchId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Batches", t => t.BatchId, cascadeDelete: true)
                .Index(t => t.BatchId);
            
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExamType = c.String(),
                        Code = c.String(),
                        Topic = c.String(nullable: false),
                        FullMarks = c.Int(nullable: false),
                        TimeDuration = c.Time(nullable: false, precision: 7),
                        OrganizationId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Organizations", t => t.OrganizationId, cascadeDelete: true)
                .Index(t => t.OrganizationId)
                .Index(t => t.CourseId);
            
            CreateTable(
                "dbo.Trainers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        IsLead = c.Boolean(nullable: false),
                        RegNo = c.String(nullable: false),
                        ContactNo = c.String(nullable: false),
                        Email = c.String(),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        City = c.String(),
                        PostalCode = c.Int(nullable: false),
                        Country = c.String(),
                        Image = c.Byte(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .Index(t => t.CourseId);
            
            CreateTable(
                "dbo.OrganizationCourses",
                c => new
                    {
                        Organization_Id = c.Int(nullable: false),
                        Course_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Organization_Id, t.Course_Id })
                .ForeignKey("dbo.Organizations", t => t.Organization_Id, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_Id, cascadeDelete: true)
                .Index(t => t.Organization_Id)
                .Index(t => t.Course_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trainers", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Batches", "Trainer_Id", "dbo.Trainers");
            DropForeignKey("dbo.Exams", "OrganizationId", "dbo.Organizations");
            DropForeignKey("dbo.Exams", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Participants", "BatchId", "dbo.Batches");
            DropForeignKey("dbo.Tags", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.OrganizationCourses", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.OrganizationCourses", "Organization_Id", "dbo.Organizations");
            DropForeignKey("dbo.Batches", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Answers", "QuestionId", "dbo.Questions");
            DropIndex("dbo.OrganizationCourses", new[] { "Course_Id" });
            DropIndex("dbo.OrganizationCourses", new[] { "Organization_Id" });
            DropIndex("dbo.Trainers", new[] { "CourseId" });
            DropIndex("dbo.Exams", new[] { "CourseId" });
            DropIndex("dbo.Exams", new[] { "OrganizationId" });
            DropIndex("dbo.Participants", new[] { "BatchId" });
            DropIndex("dbo.Tags", new[] { "CourseId" });
            DropIndex("dbo.Batches", new[] { "Trainer_Id" });
            DropIndex("dbo.Batches", new[] { "CourseId" });
            DropIndex("dbo.Batches", new[] { "BatchNo" });
            DropIndex("dbo.Answers", new[] { "QuestionId" });
            DropTable("dbo.OrganizationCourses");
            DropTable("dbo.Trainers");
            DropTable("dbo.Exams");
            DropTable("dbo.Participants");
            DropTable("dbo.Tags");
            DropTable("dbo.Organizations");
            DropTable("dbo.Courses");
            DropTable("dbo.Batches");
            DropTable("dbo.Questions");
            DropTable("dbo.Answers");
        }
    }
}
