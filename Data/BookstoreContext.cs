using Microsoft.EntityFrameworkCore;
using BookstoreAPI.Models;

namespace BookstoreAPI.Data
{
    public class BookstoreContext : DbContext
    {
        public BookstoreContext(DbContextOptions<BookstoreContext> options) : base(options)
        { }

        // Burada tablolara karşılıklı dbsetlerini burada tanmalaycağım 
        public DbSet<Book> Books { get; set; }  
        public DbSet<Category> Categories { get; set; } // Categories tablos bu da
        public DbSet<Order> Orders { get; set; }  // Orders tablosu
    }
}
