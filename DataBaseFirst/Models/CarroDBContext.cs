using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataBaseFirst.Models
{
    public partial class CarroDBContext : DbContext
    {
        public CarroDBContext()
        {
        }

        public CarroDBContext(DbContextOptions<CarroDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Carros> Carros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carros>(entity =>
            {
                entity.HasKey(e => e.CarroId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
