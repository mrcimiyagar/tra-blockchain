using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using TraBlockchain.Entities;

namespace TraBlockchain
{
    public class DatabaseContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        
        //Using Postgres as DBMS
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=TraBlockchain;Username=postgres;Password=3g5h165tsK65j1s564L69ka5R168kk37sut5ls3Sk2t");


        //Did it Code-First
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                .HasData(
                    new User {Email = "pouya1pournasir@gmail.com", Id = 1, Name = "PouyaAdmin", Password = "123"},
                    new User {Email = "Mohammad.zanjanchi@gmail.com", Id = 2, Name = "MohammadAdmin", Password = "567"}
                );

        }
    }
}