using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreWebApplication.Models
{
    public partial class CoreNetContext : DbContext
    {
        public CoreNetContext()
        {
        }

        public CoreNetContext(DbContextOptions<CoreNetContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employees> Employees { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.StudentId);

                entity.Property(e => e.EmpCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
