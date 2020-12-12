using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day15_EFCore.Entities
{
    public class HoaDon
    {
        public Guid MaHoaDon { get; set; }

        public string MaKH { get; set; }

        public string DiaChi { get; set; }

        public DateTime NgayLap { get; set; }

        public IEnumerable<ChiTietHD> chiTietHDs { get; set; }
    }

    public class ChiTietHD
    {
        public HangHoa HangHoa { get; set; }

        public HoaDon HoaDon { get; set; }

        public Guid MaHoaDon { get; set; }

        public int MaHangHoa { get; set; }

        public int SoLuong { get; set; }
    }
}
