namespace Project1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Base : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Singers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Singer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Singers", t => t.Singer_Id)
                .Index(t => t.Singer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Songs", "Singer_Id", "dbo.Singers");
            DropIndex("dbo.Songs", new[] { "Singer_Id" });
            DropTable("dbo.Songs");
            DropTable("dbo.Singers");
        }
    }
}
