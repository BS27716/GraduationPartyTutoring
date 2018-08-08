namespace GraduationPartyTutoring.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeImageandResumeTypes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tutors", "Image", c => c.String());
            AddColumn("dbo.Tutors", "Resume", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tutors", "Resume");
            DropColumn("dbo.Tutors", "Image");
        }
    }
}
