using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Day09WebApplication1.Models
{
    public  enum Gender
    {
        Nam, Nữ
    }
    public class Employee
    {
        public Guid? Id { get; set; }
        
        [Display(Name = "Mã nhân viên")]
        [Remote(action: "CheckEmployeeId", controller: "Demo")]
        public string EmployeeId { get; set; }
        
        [Display(Name = "Họ tên")]
        [Required(ErrorMessage = "*")]
        [MaxLength(150, ErrorMessage = "Tối đa 150 ký tự")]
        public string FullName { get; set; }

        [Display(Name = "Giới tính")]
        public Gender Gender { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Url]
        public string Website { get; set; }

        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        [CheckBirthDate] //check tuổi > 10 hay không??
        public DateTime BirthDate { get; set; }

        [Display(Name = "Lương")]
        [Range(0, double.MaxValue)]
        public double Salary { get; set; }

        [Display(Name = "Nhân viên bán thời gian")]
        public bool IsPartTime { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [CreditCard]
        public string CreditCard { get; set; }

        [MaxLength(255)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
    }
}
