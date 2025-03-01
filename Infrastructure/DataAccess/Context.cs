using Microsoft.EntityFrameworkCore;
using Domain.Models;

namespace Infrastructure.DataAccess
{
    public class Context : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet <Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookStoreDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
