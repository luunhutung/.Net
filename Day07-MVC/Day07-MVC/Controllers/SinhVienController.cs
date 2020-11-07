using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Day07_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Day07_MVC.Controllers
{
    public class SinhVienController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private string fileText = "dataSinhVien.txt";

        private string fileJSOn = "dataSinhVien.json";

        [HttpPost]
        public IActionResult Manage(SinhVien sv, string GhiFile)
        {
            #region Ghi thông tin đã nhập vào file JSon
            if (GhiFile == "Ghi File JSon")
            {
                var jsonSinhVien = JsonConvert.SerializeObject(sv);
                
                var path = Path.Combine(Directory.GetCurrentDirectory(), "Data", fileJSOn);

                System.IO.File.WriteAllText(path, jsonSinhVien);
            }
            #endregion

            #region Ghi thông tin đã nhập vào file Text
            else
            {
                var data = new string[]
                {
                    sv.MaSV.ToString(),
                    sv.HoTen,
                    sv.Diem.ToString()
                };

                var path = Path.Combine(Directory.GetCurrentDirectory(), "Data", fileText);

                System.IO.File.WriteAllLines(path, data);
            }
            #endregion

            return View("Index");
        }
    }
}