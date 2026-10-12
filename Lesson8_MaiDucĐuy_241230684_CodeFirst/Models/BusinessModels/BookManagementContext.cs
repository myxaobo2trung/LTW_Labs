using Lesson8_MaiDucĐuy_241230684_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
// Đừng quên using thư mục chứa các class Models của bạn ở đây

namespace Lesson8_MaiDucĐuy_241230684_CodeFirst.Models
{
    public class BookManagementContext : DbContext
    {
        public BookManagementContext(DbContextOptions<BookManagementContext> options) : base(options)
        {
        }

        // Khai báo các thuộc tính biểu diễn các tập thực thể
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}