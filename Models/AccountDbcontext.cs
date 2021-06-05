using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PTPMQL.Models
{
    public partial class AccountDbContext : DbContext
    {
        public AccountDbContext()
            : base("name=AccountDbContext")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<DanhGia> DanhGias { get; set; }

        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<ThanhToan> ThanhToans { get; set; }
        public virtual DbSet<GiaoDich> GiaoDichs { get; set; }
        public virtual DbSet<ThongTin> ThongTins { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
