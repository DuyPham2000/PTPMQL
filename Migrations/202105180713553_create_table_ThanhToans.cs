namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_ThanhToans : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ThanhToans",
                c => new
                    {
                        PhongNghi = c.String(nullable: false, maxLength: 128),
                        TienPhong = c.Int(nullable: false),
                        TienAn = c.Int(nullable: false),
                        TienGiaiTri = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PhongNghi);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ThanhToans");
        }
    }
}
