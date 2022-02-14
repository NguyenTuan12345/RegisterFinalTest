namespace RegisterFinalTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        MemberId = c.Int(nullable: false, identity: true),
                        FistName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.MemberId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Members");
        }
    }
}
