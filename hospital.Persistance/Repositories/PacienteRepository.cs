using hospital.Application.Interfaces.Repositories;
using hospital.Domain.Entities;
using hospital.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace hospital.Persistance.Repositories
{
	public class PacienteRepository : BaseRepository<Paciente>, IPacienteRepository
	{
		private readonly hospitalContext _context;
		public PacienteRepository(hospitalContext dbContext) : base(dbContext)
		{
			_context = dbContext;
		}

		public async Task<Paciente> GetByCedulaAsync(string Cedula)
		{
			var paciente = await _context.Pacientes.FirstOrDefaultAsync(p => p.Cedula == Cedula);
			return paciente;
		}
	}
}
