using EntityFrameworkIntro.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkIntro
{
    public class MusicContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=MusicExample;Trusted_Connection=True";
            optionsBuilder.UseSqlServer(connectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Song>().HasData(new Song() { Id = 1, Title = "More Than A Feeling" }, 
                new Song() { Id = 2, Title = "Never Going To Give You Up"});
        }
    }
}
