﻿using Microsoft.EntityFrameworkCore;
using hospital.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hospital.Persistance.Context;

namespace hospital.Persistance.Repositories
{
	public class BaseRepository<Entity> : IBaseRepository<Entity> where Entity : class
	{
		private readonly hospitalContext _dbContext;

		public BaseRepository(hospitalContext dbContext)
		{
			_dbContext = dbContext;
		}

		public virtual async Task AddAsync(Entity entity)
		{
			await _dbContext.Set<Entity>().AddAsync(entity);
			await _dbContext.SaveChangesAsync();
		}

		public virtual async Task UpdateAsync(Entity entity)
		{
			_dbContext.Entry(entity).State = EntityState.Modified;
			await _dbContext.SaveChangesAsync();
		}

		public virtual async Task DeleteAsync(Entity entity)
		{
			_dbContext.Set<Entity>().Remove(entity);
			await _dbContext.SaveChangesAsync();
		}

		public async Task<List<Entity>> GetAllAsync()
		{
			return await _dbContext.Set<Entity>().ToListAsync();
		}

		public virtual async Task<List<Entity>> GetAllWithIncludeAsync(List<string> properties)
		{
			var query = _dbContext.Set<Entity>().AsQueryable();

			foreach (string property in properties)
			{
				query = query.Include(property);
			}

			return await query.ToListAsync();
		}

		public virtual async Task<Entity> GetByIdAsync(int id)
		{
			return await _dbContext.Set<Entity>().FindAsync(id);
		}
	}
}