namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_TongTiens : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DichVus",
                c => new
                    {
                        PhongNghi = c.String(nullable: false, maxLength: 128),
                        DoAn = c.String(),
                        GiaiTri = c.String(),
                    })
                .PrimaryKey(t => t.PhongNghi);
            
            CreateTable(
                "dbo.TongTiens",
                c => new
                    {
                        PhongNghi = c.String(nullable: false, maxLength: 128),
                        ThanhTien = c.String(),
                    })
                .PrimaryKey(t => t.PhongNghi)
                .ForeignKey("dbo.DichVus", t => t.PhongNghi)
                .Index(t => t.PhongNghi);
            
            DropTable("dbo.DichVus");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.DichVus",
                c => new
                    {
                        PhongNghi = c.String(nullable: false, maxLength: 128),
                        DoAn = c.String(),
                        GiaiTri = c.String(),
                    })
                .PrimaryKey(t => t.PhongNghi);
            
            DropForeignKey("dbo.TongTiens", "PhongNghi", "dbo.DichVus");
            DropIndex("dbo.TongTiens", new[] { "PhongNghi" });
            DropTable("dbo.TongTiens");
            DropTable("dbo.DichVus");
        }
    }
}
