using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class CheckLabContext : DbContext
    {
        public CheckLabContext(DbContextOptions<CheckLabContext> options) : base(options) {}

        // Definicion de DbSet para cada entidad
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Enfermero> Enfermeros { get; set; }
        public DbSet<EPS> EPSs { get; set; }
        public DbSet<Afiliacion> Afiliaciones { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Examen> Examenes { get; set; }
        public DbSet<Reprogramacion> Reprogramaciones { get; set; }
        public DbSet<EstadoCita> EstadosCita { get; set; }
        public DbSet<Resultado> Resultados { get; set; }
        public DbSet<HistorialCita> HistorialesCita { get; set; }
        public DbSet<Notificacion> Notificaciones { get; set; }
        public DbSet<LogSistema> LogsSistema { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ========================
            // CONFIGURACI�N DE USUARIO
            // ========================
            modelBuilder.Entity<Usuario>(entity =>
            {
                // �ndices �nicos
                entity.HasIndex(e => e.Documento)
                      .IsUnique()
                      .HasDatabaseName("IX_Usuario_Documento");

                entity.HasIndex(e => new { e.TipoDocumento, e.Documento })
                      .IsUnique()
                      .HasDatabaseName("IX_Usuario_TipoDoc_Documento");

                // Relaci�n con Rol
                entity.HasOne(u => u.Rol)
                      .WithMany(r => r.Usuarios)
                      .HasForeignKey(u => u.RolID)
                      .OnDelete(DeleteBehavior.Restrict);

                // Configuraci�n de propiedades
                entity.Property(e => e.TipoDocumento)
                      .HasMaxLength(10)
                      .IsRequired();

                entity.Property(e => e.Documento)
                      .HasMaxLength(20)
                      .IsRequired();

                entity.Property(e => e.Contrase�a)
                      .IsRequired();

                entity.Property(e => e.Estado)
                      .HasMaxLength(20)
                      .IsRequired()
                      .HasDefaultValue("Activo");
            });

            // ========================
            // CONFIGURACI�N DE ROL
            // ========================
            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasIndex(e => e.Nombre)
                      .IsUnique()
                      .HasDatabaseName("IX_Rol_Nombre");

                entity.Property(e => e.Nombre)
                      .HasMaxLength(50)
                      .IsRequired();
            });

            // ========================
            // CONFIGURACI�N DE PACIENTE
            // ========================
            modelBuilder.Entity<Paciente>(entity =>
            {
                // Relaci�n uno a uno con Usuario
                entity.HasOne(p => p.Usuario)
                      .WithOne(u => u.Paciente)
                      .HasForeignKey<Paciente>(p => p.UsuarioFK)
                      .OnDelete(DeleteBehavior.Cascade);

                // �ndices
                entity.HasIndex(e => e.UsuarioFK)
                      .IsUnique()
                      .HasDatabaseName("IX_Paciente_UsuarioFK");

                entity.HasIndex(e => e.Correo)
                      .HasDatabaseName("IX_Paciente_Correo");

                // Configuraci�n de propiedades
                entity.Property(e => e.Nombres)
                      .HasMaxLength(100)
                      .IsRequired();

                entity.Property(e => e.Apellidos)
                      .HasMaxLength(100)
                      .IsRequired();

                entity.Property(e => e.Correo)
                      .HasMaxLength(255);

                entity.Property(e => e.Sexo)
                      .HasMaxLength(10);

                entity.Property(e => e.Telefono)
                      .HasMaxLength(20);

                entity.Property(e => e.Estado)
                      .HasMaxLength(20)
                      .IsRequired()
                      .HasDefaultValue("Activo");
            });

            // ========================
            // CONFIGURACI�N DE ENFERMERO
            // ========================
            modelBuilder.Entity<Enfermero>(entity =>
            {
                // Relaci�n uno a uno con Usuario
                entity.HasOne(e => e.Usuario)
                      .WithOne(u => u.Enfermero)
                      .HasForeignKey<Enfermero>(e => e.UsuarioFK)
                      .OnDelete(DeleteBehavior.Cascade);

                // �ndices
                entity.HasIndex(e => e.UsuarioFK)
                      .IsUnique()
                      .HasDatabaseName("IX_Enfermero_UsuarioFK");

                entity.HasIndex(e => e.Correo)
                      .HasDatabaseName("IX_Enfermero_Correo");

                // Configuraci�n de propiedades
                entity.Property(e => e.Nombres)
                      .HasMaxLength(100)
                      .IsRequired();

                entity.Property(e => e.Apellidos)
                      .HasMaxLength(100)
                      .IsRequired();

                entity.Property(e => e.Correo)
                      .HasMaxLength(255);

                entity.Property(e => e.Telefono)
                      .HasMaxLength(20);

                entity.Property(e => e.Estado)
                      .HasMaxLength(20)
                      .IsRequired()
                      .HasDefaultValue("Activo");
            });

            // ========================
            // CONFIGURACI�N DE EPS
            // ========================
            modelBuilder.Entity<EPS>(entity =>
            {
                entity.HasIndex(e => e.Nombre)
                      .IsUnique()
                      .HasDatabaseName("IX_EPS_Nombre");

                entity.Property(e => e.Nombre)
                      .HasMaxLength(100)
                      .IsRequired();

                entity.Property(e => e.Estado)
                      .HasMaxLength(20)
                      .IsRequired()
                      .HasDefaultValue("Activo");
            });

            // ========================
            // CONFIGURACI�N DE AFILIACION
            // ========================
            modelBuilder.Entity<Afiliacion>(entity =>
            {
                // Relaci�n con EPS
                entity.HasOne(a => a.EPS)
                      .WithMany()
                      .HasForeignKey(a => a.EPSID)
                      .OnDelete(DeleteBehavior.Restrict);

                // �ndices
                entity.HasIndex(e => e.Documento)
                      .HasDatabaseName("IX_Afiliacion_Documento");

                entity.HasIndex(e => new { e.TipoDocumento, e.Documento })
                      .IsUnique()
                      .HasDatabaseName("IX_Afiliacion_TipoDoc_Documento");

                // Configuraci�n de propiedades
                entity.Property(e => e.TipoDocumento)
                      .HasMaxLength(10)
                      .IsRequired();

                entity.Property(e => e.Documento)
                      .HasMaxLength(20)
                      .IsRequired();

                entity.Property(e => e.Estado)
                      .HasMaxLength(20)
                      .IsRequired()
                      .HasDefaultValue("Activo");
            });

            // ========================
            // CONFIGURACI�N DE EXAMEN
            // ========================
            modelBuilder.Entity<Examen>(entity =>
            {
                entity.HasIndex(e => e.Nombre)
                      .HasDatabaseName("IX_Examen_Nombre");

                entity.Property(e => e.Nombre)
                      .HasMaxLength(100)
                      .IsRequired();

                entity.Property(e => e.Estado)
                      .HasMaxLength(20)
                      .IsRequired()
                      .HasDefaultValue("Activo");

                entity.Property(e => e.Duracion)
                      .HasDefaultValue(0);
            });

            // ========================
            // CONFIGURACI�N DE ESTADO CITA
            // ========================
            modelBuilder.Entity<EstadoCita>(entity =>
            {
                entity.HasIndex(e => e.Descripcion)
                      .IsUnique()
                      .HasDatabaseName("IX_EstadoCita_Descripcion");

                entity.Property(e => e.Descripcion)
                      .HasMaxLength(50)
                      .IsRequired();
            });

            // ========================
            // CONFIGURACI�N DE CITA
            // ========================
            modelBuilder.Entity<Cita>(entity =>
            {
                // Relaciones
                entity.HasOne(c => c.Paciente)
                      .WithMany(p => p.Citas)
                      .HasForeignKey(c => c.PacienteID)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(c => c.Examen)
                      .WithMany(e => e.Citas)
                      .HasForeignKey(c => c.ExamenID)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(c => c.EstadoCita)
                      .WithMany(ec => ec.Citas)
                      .HasForeignKey(c => c.EstadoID)
                      .OnDelete(DeleteBehavior.Restrict);

                // �ndices
                entity.HasIndex(e => e.PacienteID)
                      .HasDatabaseName("IX_Cita_PacienteID");

                entity.HasIndex(e => e.ExamenID)
                      .HasDatabaseName("IX_Cita_ExamenID");

                entity.HasIndex(e => e.FechaHora)
                      .HasDatabaseName("IX_Cita_FechaHora");

                entity.HasIndex(e => e.EstadoID)
                      .HasDatabaseName("IX_Cita_EstadoID");

                // Configuraci�n de propiedades
                entity.Property(e => e.Estado)
                      .HasMaxLength(20)
                      .IsRequired()
                      .HasDefaultValue("Activo");

                entity.Property(e => e.FechaHora)
                      .HasColumnType("datetime2");
            });

            // ========================
            // CONFIGURACI�N DE REPROGRAMACION
            // ========================
            modelBuilder.Entity<Reprogramacion>(entity =>
            {
                // Relaci�n con Cita
                entity.HasOne(r => r.Cita)
                      .WithMany(c => c.Reprogramaciones)
                      .HasForeignKey(r => r.CitaID)
                      .OnDelete(DeleteBehavior.Cascade);

                // �ndices
                entity.HasIndex(e => e.CitaID)
                      .HasDatabaseName("IX_Reprogramacion_CitaID");

                entity.HasIndex(e => e.NuevaFecha)
                      .HasDatabaseName("IX_Reprogramacion_NuevaFecha");

                // Configuraci�n de propiedades
                entity.Property(e => e.Estado)
                      .HasMaxLength(20)
                      .IsRequired()
                      .HasDefaultValue("Activo");

                entity.Property(e => e.NuevaFecha)
                      .HasColumnType("datetime2");
            });

            // ========================
            // CONFIGURACI�N DE RESULTADO
            // ========================
            modelBuilder.Entity<Resultado>(entity =>
            {
                // Relaci�n con Cita
                entity.HasOne(r => r.Cita)
                      .WithMany(c => c.Resultados)
                      .HasForeignKey(r => r.CitaID)
                      .OnDelete(DeleteBehavior.Cascade);

                // �ndices
                entity.HasIndex(e => e.CitaID)
                      .HasDatabaseName("IX_Resultado_CitaID");

                entity.HasIndex(e => e.FechaSubida)
                      .HasDatabaseName("IX_Resultado_FechaSubida");

                // Configuraci�n de propiedades
                entity.Property(e => e.Estado)
                      .HasMaxLength(20)
                      .IsRequired()
                      .HasDefaultValue("Activo");

                entity.Property(e => e.FechaSubida)
                      .HasColumnType("datetime2")
                      .HasDefaultValueSql("GETDATE()");

                entity.Property(e => e.ArchivoPDF)
                      .IsRequired();
            });

            // ========================
            // CONFIGURACI�N DE HISTORIAL CITA
            // ========================
            modelBuilder.Entity<HistorialCita>(entity =>
            {
                // Relaci�n con Cita
                entity.HasOne(h => h.Cita)
                      .WithMany(c => c.Historiales)
                      .HasForeignKey(h => h.CitaID)
                      .OnDelete(DeleteBehavior.Cascade);

                // �ndices
                entity.HasIndex(e => e.CitaID)
                      .HasDatabaseName("IX_HistorialCita_CitaID");

                entity.HasIndex(e => e.FechaCambio)
                      .HasDatabaseName("IX_HistorialCita_FechaCambio");

                // Configuraci�n de propiedades
                entity.Property(e => e.FechaCambio)
                      .HasColumnType("datetime2")
                      .HasDefaultValueSql("GETDATE()");
            });

            // ========================
            // CONFIGURACI�N DE NOTIFICACION
            // ========================
            modelBuilder.Entity<Notificacion>(entity =>
            {
                // Relaci�n con Usuario
                entity.HasOne(n => n.Usuario)
                      .WithMany(u => u.Notificaciones)
                      .HasForeignKey(n => n.UsuarioID)
                      .OnDelete(DeleteBehavior.Cascade);

                // �ndices
                entity.HasIndex(e => e.UsuarioID)
                      .HasDatabaseName("IX_Notificacion_UsuarioID");

                entity.HasIndex(e => e.Fecha)
                      .HasDatabaseName("IX_Notificacion_Fecha");

                entity.HasIndex(e => e.Leida)
                      .HasDatabaseName("IX_Notificacion_Leida");

                // Configuraci�n de propiedades
                entity.Property(e => e.Estado)
                      .HasMaxLength(20)
                      .IsRequired()
                      .HasDefaultValue("Activo");

                entity.Property(e => e.Leida)
                      .HasDefaultValue(false);

                entity.Property(e => e.Fecha)
                      .HasColumnType("datetime2")
                      .HasDefaultValueSql("GETDATE()");
            });

            // ========================
            // CONFIGURACI�N DE LOG SISTEMA
            // ========================
            modelBuilder.Entity<LogSistema>(entity =>
            {
                // Relaci�n con Usuario
                entity.HasOne(l => l.Usuario)
                      .WithMany(u => u.Logs)
                      .HasForeignKey(l => l.UsuarioID)
                      .OnDelete(DeleteBehavior.Restrict);

                // �ndices
                entity.HasIndex(e => e.UsuarioID)
                      .HasDatabaseName("IX_LogSistema_UsuarioID");

                entity.HasIndex(e => e.FechaHora)
                      .HasDatabaseName("IX_LogSistema_FechaHora");

                // Configuraci�n de propiedades
                entity.Property(e => e.Estado)
                      .HasMaxLength(20)
                      .IsRequired()
                      .HasDefaultValue("Activo");

                entity.Property(e => e.FechaHora)
                      .HasColumnType("datetime2")
                      .HasDefaultValueSql("GETDATE()");
            });

            // ========================
            // DATOS SEMILLA (SEED DATA)
            // ========================

            // Roles por defecto
            modelBuilder.Entity<Rol>().HasData(
                new Rol { RolID = 1, Nombre = "Administrador" },
                new Rol { RolID = 2, Nombre = "Paciente" },
                new Rol { RolID = 3, Nombre = "Enfermero" }
            );

            // Estados de cita por defecto
            modelBuilder.Entity<EstadoCita>().HasData(
                new EstadoCita { EstadoID = 1, Descripcion = "Programada" },
                new EstadoCita { EstadoID = 2, Descripcion = "Confirmada" },
                new EstadoCita { EstadoID = 3, Descripcion = "En Proceso" },
                new EstadoCita { EstadoID = 4, Descripcion = "Completada" },
                new EstadoCita { EstadoID = 5, Descripcion = "Cancelada" }
            );
        }

    }
}