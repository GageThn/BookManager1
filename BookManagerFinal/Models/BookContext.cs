using Microsoft.EntityFrameworkCore;
using System.Threading;

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
                    Summary = "young adult",
                    Genre = "The Song of Achilles by Madeline Miller retells the Trojan War through the eyes of Patroclus focusing on his deep, passionate love for the legendary Greek warrior Achilles",
                    Status = "read",
                    Rating = 5
                },
                new BookModel
                {
                    BookId = 2,
                    Name = "Harry Potter and the Prisoner of Azkaban",
                    Summary = "Harry Potter enters his third year at HOgwarts only to be greeted by a tense atmosphere caused by a prisson at Azkaban escaping. Harry along with his friends learn of a connection between the prisoner and his parents. Learning of his innocence Harry travels back in time to set things right.",
                    Genre = "fantasy",
                    Status = "read",
                    Rating = 5
                },
                new BookModel
                {
                    BookId = 3,
                    Name = "I'll Give You the Sun",
                    Summary = "A brother and sister, who once were inseparable but have driven each other away. As the twins get older, and figure out what kind of people they want to be, they start to see each other and their parents not just as extensions of themselves, but as individuals.",
                    Genre = "young adult",
                    Status = "will read",
                    Rating = 4
                }
                );
        }
    }
}
