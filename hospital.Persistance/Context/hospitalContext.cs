using hospital.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace hospital.Persistance.Context
{
	public class hospitalContext : DbContext
	{
		public hospitalContext(DbContextOptions<hospitalContext> options) : base(options) 
		{ 
		}

		public DbSet<Paciente> Pacientes { get; set; }
		public DbSet<Medico> Medico { get; set; }
		public DbSet<Usuario> Usuarios { get; set; }
		public DbSet<Prueba> Prueba { get; set; }
		public DbSet<Resultado> Resultado { get; set; }
		public DbSet<Cita> Cita { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			#region tables

			modelBuilder.Entity<Paciente>()
				.ToTable("Paciente");
			modelBuilder.Entity<Medico>()
				.ToTable("Medico");
			modelBuilder.Entity<Usuario>()
				.ToTable("Usuario");
			modelBuilder.Entity<Prueba>()
				.ToTable("Prueba");
			modelBuilder.Entity<Resultado>()
				.ToTable("Resultado");
			modelBuilder.Entity<Cita>()
				.ToTable("Cita");

			#endregion

			#region "primary keys"

			modelBuilder.Entity<Paciente>()
				.HasKey(paciente => paciente.Id);
			modelBuilder.Entity<Medico>()
				.HasKey(medico => medico.Id);
			modelBuilder.Entity<Usuario>()
				.HasKey(usuario => usuario.Id);
			modelBuilder.Entity<Prueba>()
				.HasKey(prueba => prueba.Id);
			modelBuilder.Entity<Resultado>()
				.HasKey(resultado => resultado.Id);
			modelBuilder.Entity<Cita>()
				.HasKey(cita => cita.Id);

			#endregion

			#region "relations"

			modelBuilder.Entity<Paciente>()
				.HasMany<Cita>(paciente => paciente.Citas)
				.WithOne(cita => cita.Paciente)
				.HasForeignKey(cita => cita.Id_Paciente)
				.OnDelete(DeleteBehavior.SetNull);

			modelBuilder.Entity<Paciente>()
				.HasMany<Resultado>(paciente => paciente.Resultados)
				.WithOne(resultado => resultado.Paciente)
				.HasForeignKey(resultado => resultado.Id_Paciente)
				.OnDelete(DeleteBehavior.SetNull);

			modelBuilder.Entity<Medico>()
				.HasMany<Cita>(medico => medico.Citas)
				.WithOne(cita => cita.Medico)
				.HasForeignKey(cita => cita.Id_Medico)
				.OnDelete(DeleteBehavior.SetNull);

			modelBuilder.Entity<Prueba>()
				.HasMany<Resultado>(prueba => prueba.Resultados)
				.WithOne(resultado => resultado.Prueba)
				.HasForeignKey(resultado => resultado.Id_Prueba) 
				.OnDelete(DeleteBehavior.SetNull);

			modelBuilder.Entity<Cita>()
				.HasMany<Resultado>(cita => cita.Resultados)
				.WithOne(resultado => resultado.Cita)
				.HasForeignKey(resultado => resultado.Id_Cita)
				.OnDelete(DeleteBehavior.SetNull);

			#endregion

			#region "propieties"

			modelBuilder.Entity<Paciente>()
				.Property(paciente => paciente.Nombre)
				.IsRequired();
			modelBuilder.Entity<Paciente>()
				.Property(paciente => paciente.Apellido)
				.IsRequired();
			modelBuilder.Entity<Paciente>()
				.Property(paciente => paciente.Telefono)
				.IsRequired();
			modelBuilder.Entity<Paciente>()
				.Property(paciente => paciente.Foto)
				.IsRequired();
			modelBuilder.Entity<Paciente>()
				.Property(paciente => paciente.Cedula)
				.IsRequired();
			modelBuilder.Entity<Paciente>()
				.Property(paciente => paciente.Direccion)
				.IsRequired();
			modelBuilder.Entity<Paciente>()
				.Property(paciente => paciente.Fecha_nacimiento)
				.IsRequired();
			modelBuilder.Entity<Paciente>()
				.Property(paciente => paciente.EsFumador)
				.IsRequired();
			modelBuilder.Entity<Paciente>()
				.Property(paciente => paciente.EsAlegico)
				.IsRequired();

			//

			modelBuilder.Entity<Medico>()
				.Property(paciente => paciente.Nombre)
				.IsRequired();
			modelBuilder.Entity<Medico>()
				.Property(paciente => paciente.Apellido)
				.IsRequired();
			modelBuilder.Entity<Medico>()
				.Property(paciente => paciente.Telefono)
				.IsRequired();
			modelBuilder.Entity<Medico>()
				.Property(paciente => paciente.Foto)
				.IsRequired();
			modelBuilder.Entity<Medico>()
				.Property(paciente => paciente.Cedula)
				.IsRequired();
			modelBuilder.Entity<Medico>()
				.Property(paciente => paciente.Correo)
				.IsRequired();

			//

			modelBuilder.Entity<Usuario>()
				.Property(paciente => paciente.Nombre)
				.IsRequired();
			modelBuilder.Entity<Usuario>()
				.Property(paciente => paciente.Apellido)
				.IsRequired();
			modelBuilder.Entity<Usuario>()
				.Property(paciente => paciente.Correo)
				.IsRequired();
			modelBuilder.Entity<Usuario>()
				.Property(paciente => paciente.Nombre_Usuario)
				.IsRequired();
			modelBuilder.Entity<Usuario>()
				.Property(paciente => paciente.Contraseña)
				.IsRequired();
			modelBuilder.Entity<Usuario>()
				.Property(paciente => paciente.Tipo_Usuario)
				.IsRequired();

			//

			modelBuilder.Entity<Prueba>()
				.Property(paciente => paciente.Nombre)
				.IsRequired();

			//

			modelBuilder.Entity<Resultado>()
				.Property(paciente => paciente.Resultado_Final)
				.IsRequired();
			modelBuilder.Entity<Resultado>()
				.Property(paciente => paciente.Completado)
				.IsRequired();

			//

			modelBuilder.Entity<Cita>()
				.Property(paciente => paciente.Fecha_Hora)
				.IsRequired();
			modelBuilder.Entity<Cita>()
				.Property(paciente => paciente.Causa)
				.IsRequired();
			modelBuilder.Entity<Cita>()
				.Property(paciente => paciente.Estado)
				.IsRequired();

			#endregion

		}
	}
}
