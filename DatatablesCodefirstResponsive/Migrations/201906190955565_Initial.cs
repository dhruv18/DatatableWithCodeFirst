namespace DatatablesCodefirstResponsive.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.hobbies",
                c => new
                    {
                        idhobbies = c.Int(nullable: false, identity: true),
                        hobbiesName = c.String(unicode: false),
                        isselected = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.idhobbies);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        STD = c.String(unicode: false),
                        Hobies = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
            DropTable("dbo.hobbies");
        }
    }
}
