namespace WebApiService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Marks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Marks = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.EnrollCourses", "CourseMark", c => c.String());
            DropColumn("dbo.EnrollCourses", "CourseGrade");
            DropTable("dbo.Grades");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GradeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.EnrollCourses", "CourseGrade", c => c.String());
            DropColumn("dbo.EnrollCourses", "CourseMark");
            DropTable("dbo.Marks");
        }
    }
}
