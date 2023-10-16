using hospital.Application.Interfaces.Repositories;
using hospital.Domain.Entities;
using hospital.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace hospital.Persistance.Repositories
{
	public class CitaRepository : BaseRepository<Cita>, ICitaRepository
	{
		private readonly hospitalContext _context;
		public CitaRepository(hospitalContext dbContext) : base(dbContext)
		{
			_context = dbContext;
		}
	}
}
