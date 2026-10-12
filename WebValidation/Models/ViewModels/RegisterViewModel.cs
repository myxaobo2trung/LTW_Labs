using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebValidation.Models.ViewModels
{
    public class RegisterViewModel
    {
        [DisplayName("Tên đăng nhập")]
        [Required(ErrorMessage ="Tên đăng nhập không được để trống")]
        [StringLength(20, MinimumLength =3, ErrorMessage = "Độ dài tên từ 3-20 ký tự")]
        public string UserName { get; set; }

        [DisplayName("Họ và tên")]
        [Required(ErrorMessage = "Họ và tên không được để trống")]
        public string FullName { get; set; }

        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Nhập lại mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu không khớp")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [DisplayName("Hòm thư")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage ="Email không được bỏ trống")]
        public string Email { get; set; }
        [DisplayName("Điện thoại")]
        [RegularExpression(@"^0\d{9, 12}$", ErrorMessage ="Phải bắt đầu bằng 0 và dài từ 10-12 chữ số")]
        public string Phone {  get; set; }
        [DisplayName("Ngày sinh")]
        public DateTime BirthDay { get; set; }
        

    }
}
