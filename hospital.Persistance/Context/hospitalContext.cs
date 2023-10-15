using hospital.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace hospital.Persistance.Context
{
	public class hospitalContext : DbContext
	{
		public hospitalContext(DbContextOptions<hospitalContext> options) : base(options) { }

		public DbSet<Paciente> Pacientes { get; set; }
		public DbSet<Medico> Medico { get; set; }
		public DbSet<Usuario> Usuarios { get; set; }
		public DbSet<Prueba> Prueba { get; set; }
		public DbSet<Resultado> Resultado { get; set; }
		public DbSet<Cita> Cita { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Paciente>().ToTable("Paciente");
			modelBuilder.Entity<Medico>().ToTable("Medico");
			modelBuilder.Entity<Usuario>().ToTable("Usuario");
			modelBuilder.Entity<Prueba>().ToTable("Prueba");
			modelBuilder.Entity<Resultado>().ToTable("Resultado");
			modelBuilder.Entity<Cita>().ToTable("Cita");
		}
	}
}
