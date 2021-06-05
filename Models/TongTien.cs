using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL.Models
{
    [Table("TongTiens")]
    public class TongTien : DichVu

    {
        [Key]
        public string PhongNghi { get; set; }
        
        public string ThanhTien { get; set; }
    }
}