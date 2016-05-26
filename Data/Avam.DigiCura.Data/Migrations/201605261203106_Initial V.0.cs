namespace Avam.DigiCura.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialV0 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Url = c.String(),
                        IsProcessed = c.Boolean(nullable: false, defaultValue: false),
                        CreatedBy = c.String(),
                        CreatedOn = c.DateTime(nullable: false,defaultValueSql: "getutcdate()" ),
                        LastModifiedBy = c.String(),
                        LastModifiedOn = c.DateTime(nullable: false, defaultValueSql: "getutcdate()"),
                    })
                .PrimaryKey(t => t.Id);
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        CreatedBy = c.String(),
                        CreatedOn = c.DateTime(nullable: false, defaultValueSql: "getutcdate()"),
                        LastModifiedBy = c.String(),
                        LastModifiedOn = c.DateTime(nullable: false, defaultValueSql: "getutcdate()"),
                    })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
            DropTable("dbo.Articles");
        }
    }
}
