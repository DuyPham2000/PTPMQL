using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL.Models
{
    [Table("ThongTins")]
    public class ThongTin
    {
        [Key]
        public string TenKhachSan { get; set; }
        public string SoID { get; set; }
    }
}