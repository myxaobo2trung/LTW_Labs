using Lesson8_MaiDucĐuy_241230684_CodeFirst.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson8_MaiDucĐuy_241230684_CodeFirst.Models // Hãy thay bằng tên Project thực tế của bạn
{
    [Table("Books")]
    public class Book
    {
        [DisplayName("Mã sách")]
        [StringLength(10)]
        public string BookId { get; set; }

        [DisplayName("Tên sách")]
        [StringLength(200)]
        public string Title { get; set; }

        [DisplayName("Tác giả")]
        [StringLength(100)]
        public string Author { get; set; }

        [DisplayName("Năm xuất bản")]
        public int? Release { get; set; }

        [DisplayName("Giá")]
        public double? Price { get; set; }

        [DisplayName("Mô tả")]
        public string Description { get; set; }

        [DisplayName("Hình ảnh")]
        public string Picture { get; set; }

        [DisplayName("Mã nhà xuất bản")]
        public int? PublisherId { get; set; }

        [DisplayName("Mã loại")]
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
}
