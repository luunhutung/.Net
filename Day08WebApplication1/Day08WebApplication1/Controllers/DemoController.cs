using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Day08WebApplication1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using Newtonsoft.Json;

namespace Day08WebApplication1.Controllers
{
    public class DemoController : Controller
    {
        #region Demo Async
        public string DemoSync()
        {
            var demo = new Demo();
            var stopWatch = new Stopwatch();

            stopWatch.Start();

            demo.Test01();
            demo.Test02();
            demo.Test03();

            stopWatch.Stop();

            return $"Chạy hết {stopWatch.ElapsedMilliseconds}ms";
        }

        public async Task<string> DemoAsync()
        {
            var demo = new Demo();
            var stopWatch = new Stopwatch();

            stopWatch.Start();

            var a = demo.Test01Async();
            var b = demo.Test02Async();
            var c = demo.Test03Async();

            await a; await b; await c;

            stopWatch.Stop();

            return $"Chạy hết {stopWatch.ElapsedMilliseconds}ms";
        }
        #endregion

        public IActionResult Upload()
        {
            return View();
        }
        public IActionResult ThemHangHoa()
        {
            return View();
        }

        #region Upload Single File
        public IActionResult SingleFile(IFormFile MyFile)
        {
            if (MyFile != null)
            {
                var fileName = $"{DateTime.Now.Year}{DateTime.Now.Month}{DateTime.Now.Day}_{MyFile.FileName}";

                var path = Path.Combine(Directory.GetCurrentDirectory(), "Data", fileName);

                using (var file = new FileStream(path, FileMode.Create))
                {
                    MyFile.CopyTo(file);
                    ViewBag.ThongBao = "Upload thành công";
                }    
            }
            else
                ViewBag.ThongBao = "Upload thất bại";
            return View("Upload");
        }
        #endregion

        #region Upload Multiple File
        public IActionResult MultipleFile(List<IFormFile> MyFile)
        {
            if (MyFile != null)
            {
                foreach (var myFile in MyFile)
                {
                    var fileName = $"{DateTime.Now.Year}{DateTime.Now.Month}{DateTime.Now.Day}_{myFile.FileName}";

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "Data", fileName);

                    using (var file = new FileStream(path, FileMode.Create))
                    {
                        myFile.CopyTo(file);
                    }
                }
                ViewBag.ThongBao = "Upload thành công";
            }
            else
                ViewBag.ThongBao = "Upload thất bại";

            return View("Upload");
        }
        #endregion

        #region Thêm hàng hóa và lưu thành file Json
        [HttpPost]
        public IActionResult ThemHangHoa(HangHoa hangHoa, IFormFile Hinh)
        {
            if (Hinh != null)
            {
                var fileName = $"{DateTime.Now.Year}{DateTime.Now.Month}{DateTime.Now.Day}_{Hinh.FileName}";

                var path = Path.Combine(Directory.GetCurrentDirectory(), "Image", fileName);

                using (var file = new FileStream(path, FileMode.Create))
                {
                    Hinh.CopyTo(file);
                }
                hangHoa.Hinh = fileName;

                var jsonContent = JsonConvert.SerializeObject(hangHoa);

                var jsonPath = Path.Combine(Directory.GetCurrentDirectory(), "Data", $"{hangHoa.MaHH}.json");

                System.IO.File.WriteAllText(jsonPath, jsonContent);
            }
            
            return View("ThemHangHoa");
        }
        #endregion
    }
}