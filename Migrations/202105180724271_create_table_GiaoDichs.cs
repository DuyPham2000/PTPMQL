namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_GiaoDichs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GiaoDichs",
                c => new
                    {
                        MaID = c.String(nullable: false, maxLength: 128),
                        TenID = c.String(),
                        TinhTrang = c.String(),
                    })
                .PrimaryKey(t => t.MaID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GiaoDichs");
        }
    }
}
