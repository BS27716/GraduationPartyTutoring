namespace GraduationPartyTutoring.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddResponseTimetoTutorDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tutors", "ResponseTime", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tutors", "ResponseTime");
        }
    }
}
