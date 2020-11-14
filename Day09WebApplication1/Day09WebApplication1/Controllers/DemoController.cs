using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day09WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day09WebApplication1.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Employee employee)
        {
            if (ModelState.IsValid)
            {

            }
            else
            {
                ModelState.AddModelError("Error", "Error");
            }    
            return View();
        }

        public IActionResult CheckEmployeeId(string EmployeeId)
        {
            var userId = new string[]
            {
                "admin", "nhatnghe", "hocvien"
            };
            //LINQ
            var danhSach = userId.Select(p => p.ToLower()).ToList();

            if (userId.Contains(EmployeeId.ToLower()))
            {
                return Json(false);
            }
            return Json(true);
        }

        public IActionResult DangKy()
        {
            return View();
        }
    }
}