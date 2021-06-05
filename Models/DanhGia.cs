using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL.Models
{
    [Table("DanhGias")]
    public class DanhGia
    {
        [Key]
        public string MaID { get; set; }
        public string TenID { get; set; }
        public string SoSao { get; set; }
        public string TiengAnh { get; set; }

    }
}