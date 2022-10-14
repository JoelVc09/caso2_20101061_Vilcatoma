using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace caso2_20101061_Vilcatoma.Infraestructure.Data
{
    public partial class Parcial202220101061Context : DbContext
    {
        public Parcial202220101061Context()
        {
        }

        public Parcial202220101061Context(DbContextOptions<Parcial202220101061Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Patient> Patient { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-L2HIARQP;Database=Parcial202220101061;Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.CategoriaId)
                    .HasName("pk_categoria_id");

                entity.Property(e => e.CategoriaId)
                    .ValueGeneratedNever()
                    .HasColumnName("categoria_id");

                entity.Property(e => e.DateOfBirth)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
