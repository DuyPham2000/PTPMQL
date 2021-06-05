namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_NhanViens : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        TenID = c.String(nullable: false, maxLength: 128),
                        MaID = c.String(),
                        DiaChi = c.String(),
                    })
                .PrimaryKey(t => t.TenID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NhanViens");
        }
    }
}
