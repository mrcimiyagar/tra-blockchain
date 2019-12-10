using Microsoft.EntityFrameworkCore;
using TraBlockchain.Entities;

namespace TraBlockchain
{
    public class DatabaseContext: DbContext
    {
        private DbSet<User> Users { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost:5432;Database=TraBlockchain;Username=postgres;Password=pouya258");


    }
}