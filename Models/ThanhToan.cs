using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL.Models
{
    [Table("ThanhToans")]
    public class ThanhToan
    {
        [Key]
        public string PhongNghi { get; set; }
        public int TienPhong { get; set; }
        public int TienAn { get; set; }
        public int TienGiaiTri { get; set; }
    }
}