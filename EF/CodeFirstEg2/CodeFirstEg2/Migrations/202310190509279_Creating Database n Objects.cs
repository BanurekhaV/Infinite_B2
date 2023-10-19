namespace CodeFirstEg2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatingDatabasenObjects : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblAuthors",
                c => new
                    {
                        AuthorID = c.Int(nullable: false, identity: true),
                        AuthorName = c.String(),
                    })
                .PrimaryKey(t => t.AuthorID);
            
            CreateTable(
                "dbo.tblBooks",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        BookName = c.String(),
                    })
                .PrimaryKey(t => t.BookId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblBooks");
            DropTable("dbo.tblAuthors");
        }
    }
}
