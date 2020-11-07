
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Day07_MVC.Models
{
    public class SinhVien
    {
        [Display(Name = "Mã Sinh Viên")]
        public string MaSV { get; set; }

        [Display(Name = "Họ và Tên")]
        public string HoTen { get; set; }

        [Display(Name = "Điểm")]
        public double Diem { get; set; }

        [Display(Name = "Xếp loại")]
        public string XepLoai
        {
            get 
            {
                if (Diem < 5)
                    return "Yếu";
                if (Diem < 6.5)
                    return "Trung bình";
                if (Diem < 8.5)
                    return "Khá";
                return "Giỏi";
            }
        }
    }
}
