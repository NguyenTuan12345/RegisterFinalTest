namespace RegisterFinalTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tengi : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Members", "Password", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Members", "Password", c => c.String(nullable: false));
        }
    }
}
