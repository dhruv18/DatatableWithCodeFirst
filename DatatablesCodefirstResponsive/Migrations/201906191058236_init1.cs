namespace DatatablesCodefirstResponsive.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Students", "abc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "abc", c => c.Int(nullable: false));
        }
    }
}
