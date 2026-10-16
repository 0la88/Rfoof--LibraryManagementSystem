using Microsoft.EntityFrameworkCore;
using Rfoof_1.Models;

namespace Rfoof_1.Data
{
    public class WebDBcontext : DbContext
    {
        public WebDBcontext(DbContextOptions<WebDBcontext> options) : base(options){ }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Reader> Readers { get; set; }

        protected override void OnModelCreating(ModelBuilder Builder)
        {
            base.OnModelCreating(Builder);

            Builder.Entity<Book>().HasData(
               
                new Book()
                {
                    Id = 1, 
                    Title = "The Great Gatsby",
                    price = 10.99m,
                    AuthorId = 1,
                    CategoryId = 1,
                    ReaderId = 1
                },
                new Book()
                {
                    Id = 2,
                    Title = "To Kill a Mockingbird",
                    price = 12.99m,
                    AuthorId = 2,
                    CategoryId = 2,
                    ReaderId = 2
                }
                );
        }

    }
}
