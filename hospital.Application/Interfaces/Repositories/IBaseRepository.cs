

namespace hospital.Application.Interfaces.Repositories
{
	public interface IBaseRepository<Entity> where Entity : class
	{
		Task AddAsync(Entity entity);
		Task UpdateAsync(Entity entity);
		Task DeleteAsync(Entity entity);
		Task<List<Entity>> GetAllAsync();
		Task<Entity> GetByIdAsync(int id);
		Task<List<Entity>> GetAllWithIncludeAsync(List<string> properties);
	}
}
