using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL.Models
{
    [Table("NhanViens")]
    public class NhanVien
    {
        [Key]
        public string TenID { get; set; }
        public string MaID { get; set; }
        public string DiaChi { get; set; }
    }
}