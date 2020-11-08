using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Day08WebApplication1.Models
{
    public class HangHoa
    {
        [Display(Name = "Mã hàng hóa")]
        public int MaHH { get; set; }

        [Display(Name = "Tên hàng hóa")]
        public string TenHH { get; set; }

        [Display(Name = "Hình ")]
        public string Hinh { get; set; }

        [Display(Name = "Đơn giá")]
        public double DonGia { get; set; }

        [Display(Name = "Số lượng")]
        public int SoLuong { get; set; }

        [Display(Name = "Thành tiền")]
        public double ThanhTien => DonGia * SoLuong;
    }
}
