using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Day15_EFCore.Entities
{
    [Table("HangHoa")]
    public class HangHoa
    {
        [Key]
        public int MaHangHoa { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string TenHangHoa { get; set; }

        public double DonGia { get; set; }

        public int SoLuongTon { get; set; }
        
        public int MaLoai { get; set; }
        
        [ForeignKey("MaLoai")]
        public Loai Loai { get; set; }

        public IEnumerable<ChiTietHD> chiTietHDs { get; set; }

    }
}
