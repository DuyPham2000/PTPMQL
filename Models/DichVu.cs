using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL.Models
{
    [Table("GiaiTris")]
    public class DichVu
    {
        [Key]
        public string PhongNghi { get; set; }
        public string DoAn { get; set; }
        public string GiaiTri { get; set; }
    }
}