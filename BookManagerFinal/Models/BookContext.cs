using Microsoft.EntityFrameworkCore;

namespace BookManagerFinal.Models
{
    public class BookContext : DbContext
    {
        //constructor
        public BookContext(DbContextOptions<BookContext> options) : base(options) { }

        public DbSet<BookModel> Books { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<BookModel>().HasData(
                new BookModel
                {
                    BookId = 1,
                    Name = "Song of Achilles",
                    Description = "young adult",
                    Genre = "young adult",
                    Status = "read",
                    Rating = 5
                },
                new BookModel
                {
                    BookId = 2,
                    Name = "Harry Potter and the Prisoner of Azkaban",
                    Description = "fantasy",
                    Genre = "fantasy",
                    Status = "read",
                    Rating = 5
                },
                new BookModel
                {
                    BookId = 3,
                    Name = "I'll Give You the Sun",
                    Description = "young adult",
                    Genre = "young adult",
                    Status = "will read",
                    Rating = 4
                }
                );
        }
    }
}
