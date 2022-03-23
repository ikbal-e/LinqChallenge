using LinqChallenge.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace LinqChallenge.API.Infrastructure.Data;

public class BookStoreDbContext : DbContext
{
    public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>().HasData(
            new Author { Id = 1, Name = "Mark Twain" },
            new Author { Id = 2, Name = "Charles Dickens" }
            );
    }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }

}
