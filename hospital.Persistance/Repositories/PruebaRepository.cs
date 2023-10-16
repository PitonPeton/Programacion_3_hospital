using hospital.Application.Interfaces.Repositories;
using hospital.Domain.Entities;
using hospital.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace hospital.Persistance.Repositories
{
	public class PruebaRepository : BaseRepository<Prueba>, IPruebaRepository
	{
		private readonly hospitalContext _context;
		public PruebaRepository(hospitalContext dbContext) : base(dbContext)
		{
			_context = dbContext;
		}
	}
}
