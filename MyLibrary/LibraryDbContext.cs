using System.Data.Entity;

namespace MyLibrary
{
    class LibraryDbContext : DbContext
    {
        public LibraryDbContext() : base("DbConnectionString")
        {

        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
