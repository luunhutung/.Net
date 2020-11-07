using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using Day07_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day07_MVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.HoTen = "Nhất Nghệ";
            ViewData["DienThoai"] = 123456789;
            ViewData["Ngày Sinh"] = new DateTime(2000, 12, 31);

            var hanghoa = new HangHoa
            {
                MaHH = 1,
                TenHH = "Iphone 12",
                DonGia = 12345678,
                SoLuong = 3
            };
            ViewBag.DienThoai = hanghoa;


            return View();
        }

        public IActionResult DanhSach()
        {
            var data = new List<HangHoa>();
            data.Add(new HangHoa
            {
                MaHH = 1,
                TenHH = "Iphone 12",
                DonGia = 40000000,
                SoLuong = 1,
                Hinh = "iphone.jpg"
            });
            data.Add(new HangHoa
            {
                MaHH = 2,
                TenHH = "MacBook Pro 2020",
                DonGia = 61000000,
                SoLuong = 1,
                Hinh = "macbook.jpg"
            });

            return View(data);
        }

        public IActionResult ChiTiet()
        {
            var hangHoa = new HangHoa
            {
                MaHH = 2,
                TenHH = "MacBook Pro 2020",
                DonGia = 61000000,
                SoLuong = 1,
                Hinh = "macbook.jpg"
            };
            return View(hangHoa);
        }

        public IActionResult ThemHangHoa()
        {

            return View();
        }
    }
}