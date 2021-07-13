namespace SchoolSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProblemFixed : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "MobileNo", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "MobileNo", c => c.Int(nullable: false));
        }
    }
}
