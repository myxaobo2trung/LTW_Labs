namespace MDD_TH2_Lab3.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

public class Student
{
    public int Id { get; set; } 

    [Display(Name = "Họ tên")]
    [Required(ErrorMessage = "Họ tên bắt buộc phải nhập")]
    [StringLength(100, MinimumLength = 4, ErrorMessage = "Họ tên phải từ 4 đến 100 ký tự")]
    public string? Name { get; set; }

    [Display(Name = "Địa chỉ Email")]
    [Required(ErrorMessage = "Email bắt buộc phải được nhập")]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@gmail\.com$", ErrorMessage = "Địa chỉ email phải có đuôi gmail.com")]
    public string? Email { get; set; }

    [Display(Name = "Mật khẩu")]
    [Required(ErrorMessage = "Mật khẩu bắt buộc phải nhập")]
    [StringLength(100, MinimumLength = 8, ErrorMessage = "Mật khẩu phải từ 8 ký tự trở lên")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$", ErrorMessage = "Mật khẩu phải có ký tự viết hoa, viết thường, chữ số và ký tự đặc biệt")]
    public string? Password { get; set; }

    [Display(Name = "Ngành học")]
    [Required(ErrorMessage = "Vui lòng chọn ngành học")]
    public Branch? Branch { get; set; }

    [Display(Name = "Giới tính")]
    [Required(ErrorMessage = "Vui lòng chọn giới tính")]
    public Gender? Gender { get; set; }

    [Display(Name = "Hệ chính quy")]
    public bool IsRegular { get; set; }

    [Display(Name = "Địa chỉ")]
    [Required(ErrorMessage = "Địa chỉ bắt buộc phải nhập")]
    [DataType(DataType.MultilineText)]
    public string? Address { get; set; }

    [Display(Name = "Ngày sinh")]
    [Required(ErrorMessage = "Ngày sinh bắt buộc phải nhập")]
    [Range(typeof(DateTime), "1963-01-01", "2005-12-31", ErrorMessage = "Ngày sinh phải nằm trong khoảng 1963 - 2005")]
    [DataType(DataType.Date)]
    public DateTime DateOfBorth { get; set; }

    // Trường mới thêm theo yêu cầu bước 4
    [Display(Name = "Điểm số")]
    [Required(ErrorMessage = "Điểm số bắt buộc phải nhập")]
    [Range(0.0, 10.0, ErrorMessage = "Điểm phải là số thực từ 0.0 đến 10.0")]
    public double? Score { get; set; }
    
}
public enum Branch
{
    IT = 1,
    BE = 2,
    CE = 3,
    EE = 4
}

public enum Gender
{
    Male,
    Female
}
