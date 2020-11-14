using System;
using System.ComponentModel.DataAnnotations;

namespace Day09WebApplication1.Models
{
    internal class CheckBirthDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                var ngaysinh = (DateTime)value;

                if (DateTime.Now.Year - ngaysinh.Year < 10)
                    return new ValidationResult("Chưa đủ tuổi đăng ký");

                return ValidationResult.Success;
            }
            catch
            {
                return new ValidationResult("Dữ liệu không hợp lệ");
            }
        }
    }
}