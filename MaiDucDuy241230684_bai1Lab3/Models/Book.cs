using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

//Code by Mai Duc Duy
namespace Bai1_Lab3.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int TotalPage { get; set; }
        public string Summary { get; set; }

        //danh sach cac cuon sach
        public List<Book> GetBookList()
        {
            List<Book> books = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Title = "Chí Phèo",
                    AuthorId = 1,
                    GenreId = 1,
                    Image = "/images/chipheo.jpg",
                    Price = 500000,
                    Summary = "",
                    TotalPage = 250
                },
                new Book()
                {
                    Id = 2,
                    Title = "Dế mèn phiêu lưu ký",
                    AuthorId = 2,
                    GenreId = 2,
                    Image = "/images/demen.jpg",
                    Price = 500000,
                    Summary = "",
                    TotalPage = 250
                },
                new Book()
                {
                    Id = 3,
                    Title = "Vở kịch thiên nga",
                    AuthorId = 3,
                    GenreId = 3,
                    Image = "/images/thiennga.jpg",
                    Price = 500000,
                    Summary = "",
                    TotalPage = 250
                },
                new Book()
                {
                    Id = 4,
                    Title = "Yêu từ cái nhìn đầu tiên",
                    AuthorId = 4,
                    GenreId = 4,
                    Image = "/images/yeu.jpg",
                    Price = 500000,
                    Summary = "",
                    TotalPage = 250
                }
            };
            return books;
        }

        // chi tiet 1 cuon sach theo id
        public Book GetBookById(int id)
        {
            Book book = this.GetBookList().FirstOrDefault(b => b.Id == id);
            return book;
        }

        //SelectListItem Authors
        public List<SelectListItem> Authors { get; } = new List<SelectListItem>
        {
            new SelectListItem {Value = "1", Text = "Nam Cao"},
            new SelectListItem {Value = "2", Text = "Ngô Tất Tố"},
            new SelectListItem {Value = "3", Text = "Nguyễn Văn B"},
            new SelectListItem {Value = "4", Text = "Nguyễn Văn A"}
        };
        //SelectListItem Genres
        public List<SelectListItem> Genres { get; } = new List<SelectListItem>
        {
            new SelectListItem {Value = "1", Text = "Truyện Tranh"},
            new SelectListItem {Value = "2", Text = "Văn Học Đương Đại"},
            new SelectListItem {Value = "3", Text = "Văn Học"},
            new SelectListItem {Value = "4", Text = "Văn Học"}
        };
    }
}


