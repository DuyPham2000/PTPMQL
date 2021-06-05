namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_table_Account : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "PassWord", c => c.String(nullable: false));
            DropColumn("dbo.Accounts", "PassWork");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Accounts", "PassWork", c => c.String());
            DropColumn("dbo.Accounts", "PassWord");
        }
    }
}
