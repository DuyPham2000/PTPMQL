using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTPMQL.Models
{
    [Table("GiaoDichs")]
    public class GiaoDich
    {
        [Key]
        public string MaID { get; set; }
        public string TenID { get; set; }
        [AllowHtml]

        public string TinhTrang { get; set; }
    }
}