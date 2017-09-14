using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DotnetCoreWithEFCore
{
    public partial class BooksSample2Context : DbContext
    {
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<MyBooks> MyBooks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"server=(localdb)\mssqllocaldb;database=BooksSample2;trusted_connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey });

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<MyBooks>(entity =>
            {
                entity.HasKey(e => e.BookId);

                entity.Property(e => e.Publisher)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Title).HasMaxLength(60);
            });
        }
    }
}
