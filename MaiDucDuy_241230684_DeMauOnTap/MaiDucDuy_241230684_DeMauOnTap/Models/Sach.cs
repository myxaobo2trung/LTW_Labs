using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MaiDucDuy_241230684_DeMauOnTap.Models;

public partial class Sach
{
    public int MaSach { get; set; }
    [Display(Name = "MaTL")]
    [Required(ErrorMessage = "Vui lòng chọn thể loại")]
    public int MaTl { get; set; }

    [Display(Name = "TenSach")]
    [Required(ErrorMessage = "Tên sách không được để trống")]
    public string TenSach { get; set; } = null!;

    [Display(Name = "Gia")]
    [Required(ErrorMessage = "Giá không được để trống")]
    [Range(50, 1000, ErrorMessage = "Giá phải là số nằm trong khoảng 50 đến 1000")]
    public decimal? Gia { get; set; }

    public string? Anh { get; set; }

    public virtual TheLoai? MaTlNavigation { get; set; } = null!;
}
