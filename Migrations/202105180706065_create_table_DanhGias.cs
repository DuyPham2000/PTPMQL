namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_DanhGias : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DanhGias",
                c => new
                    {
                        MaID = c.String(nullable: false, maxLength: 128),
                        TenID = c.String(),
                        SoSao = c.String(),
                        TiengAnh = c.String(),
                    })
                .PrimaryKey(t => t.MaID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DanhGias");
        }
    }
}
