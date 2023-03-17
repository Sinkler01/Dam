using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Dam.Database
{
    public partial class EfModel : DbContext
    {
        private static EfModel Inst;
        public static EfModel Init()
        {
            if (Inst == null) 
            Inst = new EfModel();
            return Inst;
        }
        public EfModel()
        {
        }

        public EfModel(DbContextOptions<EfModel> options)
            : base(options)
        {
        }

        public virtual DbSet<Hookah> Hookahs { get; set; } = null!;
        public virtual DbSet<Tabac> Tabacs { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Ychastniki> Ychastnikis { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=cfif31.ru;port=3306;user id=ISPr22-43_BykovYA;password=ISPr22-43_BykovYA;character set=utf8;database=ISPr22-43_BykovYA_Tusa", ServerVersion.Parse("8.0.32-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Hookah>(entity =>
            {
                entity.HasKey(e => e.IdHookah)
                    .HasName("PRIMARY");

                entity.ToTable("Hookah");

                entity.Property(e => e.IdHookah).HasColumnName("idHookah");

                entity.Property(e => e.Name).HasColumnType("text");

                entity.Property(e => e.Zametki).HasColumnType("text");
            });

            modelBuilder.Entity<Tabac>(entity =>
            {
                entity.HasKey(e => e.IdTabac)
                    .HasName("PRIMARY");

                entity.ToTable("Tabac");

                entity.Property(e => e.IdTabac).HasColumnName("idTabac");

                entity.Property(e => e.Name).HasColumnType("text");

                entity.Property(e => e.Vid).HasColumnType("text");

                entity.Property(e => e.Zametki).HasColumnType("text");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUsers)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdUsers).HasColumnName("idUsers");

                entity.Property(e => e.Login).HasColumnType("text");

                entity.Property(e => e.Password).HasColumnType("text");

                entity.Property(e => e.Roll).HasColumnType("text");
            });

            modelBuilder.Entity<Ychastniki>(entity =>
            {
                entity.HasKey(e => e.IdYchastniki)
                    .HasName("PRIMARY");

                entity.ToTable("Ychastniki");

                entity.Property(e => e.IdYchastniki).HasColumnName("idYchastniki");

                entity.Property(e => e.Fio)
                    .HasColumnType("text")
                    .HasColumnName("FIO");

                entity.Property(e => e.Zametki).HasColumnType("text");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
