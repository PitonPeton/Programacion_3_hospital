using hospital.Application.Interfaces.Repositories;
using hospital.Domain.Entities;
using hospital.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace hospital.Persistance.Repositories
{
	public class MedicoRepository : BaseRepository<Medico>, IMedicoRepository
	{
		private readonly hospitalContext _context;
		public MedicoRepository(hospitalContext dbContext) : base(dbContext)
		{
			_context = dbContext;
		}
	}
}
