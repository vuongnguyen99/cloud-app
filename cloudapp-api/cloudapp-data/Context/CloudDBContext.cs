using System;
using Microsoft.EntityFrameworkCore;
using cloudapp_data.Models;

namespace cloudapp_data.Context
{
    public partial class CloudDBContext : DbContext
    {
        public CloudDBContext()
        {
        }

        public CloudDBContext(DbContextOptions<CloudDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
        public virtual DbSet<UserImage> UserImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users");

                entity.HasKey(x=>x.Id);

                entity.Property(e => e.CreateBy).HasMaxLength(255);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.LastModified).HasColumnType("datetime");

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.UserName).HasMaxLength(255);
            });

            modelBuilder.Entity<Salary>(entity =>
            {
                entity.ToTable("Salaries");

                entity.HasKey(x=>x.Id);

                entity.Property(e => e.DateSalary).HasColumnType("datetime");

                entity.Property(e => e.PayRate).IsRequired();

                entity.HasOne(x => x.Users).WithOne(x => x.Salaries).HasForeignKey<Salary>(x => x.UserId);
            });

            modelBuilder.Entity<UserImage>(entity =>
            {
                entity.ToTable("UserImages");

                entity.HasKey(x => x.Id);

                entity.Property(e => e.ImagePath).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.HasOne(x => x.Users).WithMany(x => x.UserImages).HasForeignKey(x => x.UserId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}