using BaiLabTH.Model;
using Microsoft.EntityFrameworkCore;


namespace BaiLabTH.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book_Author>()
                .HasKey(bc => new { bc.BookID, bc.AuthorID });

            modelBuilder.Entity<Book_Author>()
                .HasOne(bc => bc.Book)
                .WithMany(b => b.Book_Authors)
                .HasForeignKey(bc => bc.BookID);

            modelBuilder.Entity<Book_Author>()
                .HasOne(bc => bc.Author)
                .WithMany(a => a.Book_Authors)
                .HasForeignKey(bc => bc.AuthorID);
        }



        public DbSet<Book> books { get; set; }
        public DbSet<Authors> authors { get; set; }
        public DbSet<Book_Author> book_Authors { get; set; }
        public DbSet<Publishers> pulishers { get; set; }
        public object Books { get; internal set; }
    }
}

