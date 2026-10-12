using Lesson8_MaiDucĐuy_241230684_CodeFirst.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson8_MaiDucĐuy_241230684_CodeFirst.Models
{
    [Table("Categories")]
    public class Category
    {
        [DisplayName("Mã loại")]
        public int CategoryId { get; set; }

        [DisplayName("Tên loại")]
        [StringLength(100)]
        public string CategoryName { get; set; } 
        public virtual ICollection<Book> Books { get; set; }
    }
}
