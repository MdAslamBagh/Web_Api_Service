namespace WebApiService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Courses", "CourseAssignTo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "CourseAssignTo", c => c.String());
        }
    }
}
