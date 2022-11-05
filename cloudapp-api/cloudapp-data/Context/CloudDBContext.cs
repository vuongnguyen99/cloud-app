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
        //public virtual DbSet<Salary> Salaries { get; set; }
        //public virtual DbSet<UserImage> UserImages { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Salary>(entity =>
            //{
            //    entity.ToTable("Salaries");

            //    entity.Index(x => x.Guid);

            //    entity.Property(e => e.DateSalary).HasColumnType("datetime");

            //    entity.Property(e => e.PayRate).IsRequired();

            //    entity.Property(e => e.CreateDate)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getutcdate())");


            //    entity.HasOne(x => x.Users).WithOne(x => x.Salaries).HasForeignKey<Salary>(x => x.UserId);
            //});

            //modelBuilder.Entity<UserImage>(entity =>
            //{
            //    entity.ToTable("UserImages");

            //    entity.HasKey(x => x.Guid);

            //    entity.HasIndex(x => x.Id);

            //    entity.Property(e => e.ImagePath).HasMaxLength(255);

            //    entity.Property(e => e.CreateDate)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getutcdate())");


            //    entity.HasOne(x => x.Users).WithMany(x => x.UserImages).HasForeignKey(x => x.UserId);
            //});

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users");

                entity.HasIndex(x=>x.Guid);

                entity.Property(e => e.CreateBy).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.CreateDate)
                   .HasColumnType("datetime")
                   .HasDefaultValueSql("(getutcdate())");

            });
            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.HasIndex(x => x.Guid);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("UserRole");
                entity.HasKey(e => new {e.UserId, e.RoleId});

                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => e.RoleId);

                entity.HasIndex(e => new { e.UserId, e.RoleId })
                    .HasName("UQ_UserRole_UserId_RoleId")
                    .IsUnique();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRole_User");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRole_Role");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}