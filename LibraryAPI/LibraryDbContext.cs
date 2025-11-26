using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;

namespace LibraryAPI
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {
        }
        public DbSet<Entities.Book> Books { get; set; }
        public DbSet<Entities.User> Users { get; set; }
        public DbSet<Entities.Loan> Loans { get; set; }
        public DbSet<Entities.Library> Libraries { get; set; }   
    }
}
