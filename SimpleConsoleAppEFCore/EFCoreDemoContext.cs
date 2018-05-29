using Microsoft.EntityFrameworkCore;

namespace SimpleConsoleAppEFCore
{
    class EFCoreDemoContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-K45PQCH;Database=EFCoreDemo;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
