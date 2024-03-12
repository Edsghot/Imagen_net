using _5._0.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace _5._0.DataAccessLayer.Connection
{
    public class DataBaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Gallery> Gallerys { get; set; }

        public DataBaseContext()
        {
            InitAutoMapper.start();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("tuser");
            modelBuilder.Entity<Gallery>().ToTable("tgallery");

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-0MM2HVP;Database=bkImagen;User Id=sa;Password=123456;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}