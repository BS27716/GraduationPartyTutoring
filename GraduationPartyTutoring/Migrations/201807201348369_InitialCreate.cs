namespace GraduationPartyTutoring.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tutors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                        State = c.String(),
                        DOB = c.DateTime(nullable: false),
                        Payrate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Tutor_ID = c.Int(),
                        Tutor_ID1 = c.Int(),
                        Tutor_ID2 = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Tutors", t => t.Tutor_ID)
                .ForeignKey("dbo.Tutors", t => t.Tutor_ID1)
                .ForeignKey("dbo.Tutors", t => t.Tutor_ID2)
                .Index(t => t.Tutor_ID)
                .Index(t => t.Tutor_ID1)
                .Index(t => t.Tutor_ID2);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tutors", "Tutor_ID2", "dbo.Tutors");
            DropForeignKey("dbo.Tutors", "Tutor_ID1", "dbo.Tutors");
            DropForeignKey("dbo.Tutors", "Tutor_ID", "dbo.Tutors");
            DropIndex("dbo.Tutors", new[] { "Tutor_ID2" });
            DropIndex("dbo.Tutors", new[] { "Tutor_ID1" });
            DropIndex("dbo.Tutors", new[] { "Tutor_ID" });
            DropTable("dbo.Tutors");
        }
    }
}
