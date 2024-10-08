using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using TP02.Models;

namespace TP02
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options) : base(options)
        {
        }

        public DbSet<BL> BLs { get; set; }
        public DbSet<Container> Containers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relacionamento 1:N entre BL e Container
            modelBuilder.Entity<Container>()
                .HasOne(c => c.BL)       // Um Container tem um BL
                .WithMany(b => b.Containers)  // Um BL pode ter muitos Containers
                .HasForeignKey(c => c.BlId);  // Usamos BLId como chave estrangeira

            base.OnModelCreating(modelBuilder);
        }
    }
}
