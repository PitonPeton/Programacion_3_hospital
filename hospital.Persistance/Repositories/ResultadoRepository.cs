using hospital.Application.Interfaces.Repositories;
using hospital.Domain.Entities;
using hospital.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace hospital.Persistance.Repositories
{
	public class ResultadoRepository : BaseRepository<Resultado>, IResultadoRepository
	{
		private readonly hospitalContext _context;
		public ResultadoRepository(hospitalContext dbContext) : base(dbContext)
		{
			_context = dbContext;
		}
	}
}
