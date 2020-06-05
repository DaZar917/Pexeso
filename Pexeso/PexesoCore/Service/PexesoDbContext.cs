using Microsoft.EntityFrameworkCore;
using Pexeso.PexesoCore.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pexeso
{
    public class PexesoDbContext : DbContext
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DbSet<Time> Times { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Star> Stars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PexesoDb;Trusted_Connection=True;");
        }
    }
}