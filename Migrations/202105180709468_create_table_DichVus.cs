namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_DichVus : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GiaiTris",
                c => new
                    {
                        PhongNghi = c.String(nullable: false, maxLength: 128),
                        DoAn = c.String(),
                        GiaiTri = c.String(),
                    })
                .PrimaryKey(t => t.PhongNghi);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GiaiTris");
        }
    }
}
