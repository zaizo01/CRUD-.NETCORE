using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SchoolApp.Models
{
    public partial class SchoolContext : DbContext
    {
        public SchoolContext()
        {
        }

        public SchoolContext(DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<Estudiantes> Estudiantes { get; set; }
        public virtual DbSet<Materias> Materias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=A19B00647\\MSQLSERVER;Initial Catalog=SchoolApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>(entity =>
            {
                entity.HasKey(e => e.IdCurso)
                    .HasName("PK__Curso__C41493177E944340");

                entity.Property(e => e.IdCurso).HasColumnName("ID_curso");

                entity.Property(e => e.CantDeEstudiantes).HasColumnName("Cant_de_Estudiantes");

                entity.Property(e => e.Grado)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ProfesorEncargado)
                    .HasColumnName("Profesor_encargado")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Seccion)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Estudiantes>(entity =>
            {
                entity.HasKey(e => e.IdEstudiantes)
                    .HasName("PK__Estudian__E808EB49C5E15C84");

                entity.Property(e => e.IdEstudiantes).HasColumnName("ID_estudiantes");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.IdCurso).HasColumnName("ID_curso");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCursoNavigation)
                    .WithMany(p => p.Estudiantes)
                    .HasForeignKey(d => d.IdCurso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_curso");
            });

            modelBuilder.Entity<Materias>(entity =>
            {
                entity.HasKey(e => e.IdMaterias)
                    .HasName("PK__Materias__DF8526171817837A");

                entity.Property(e => e.IdMaterias).HasColumnName("ID_materias");

                entity.Property(e => e.Duracion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Horario)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IdCurso).HasColumnName("ID_curso");

                entity.Property(e => e.Materia)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Profesor)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCursoNavigation)
                    .WithMany(p => p.Materias)
                    .HasForeignKey(d => d.IdCurso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cursos");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
