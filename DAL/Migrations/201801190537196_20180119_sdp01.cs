namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20180119_sdp01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RedisMQLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 200, unicode: false, storeType: "nvarchar"),
                        Content = c.String(maxLength: 500, unicode: false, storeType: "nvarchar"),
                        CDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RedisMQLogs");
        }
    }
}
