namespace WebApiService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Students", new[] { "DepartmentId" });
            DropColumn("dbo.Students", "RegDate");
            DropColumn("dbo.Students", "DepartmentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "DepartmentId", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "RegDate", c => c.DateTime(nullable: false));
            CreateIndex("dbo.Students", "DepartmentId");
            AddForeignKey("dbo.Students", "DepartmentId", "dbo.Departments", "Id", cascadeDelete: true);
        }
    }
}
