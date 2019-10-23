using Microsoft.EntityFrameworkCore;
using MinhaAPI.Business.Interfaces.Repositories;
using MinhaAPI.Business.Models;
using MinhaAPI.Data.Context;
using System;

namespace MinhaAPI.Data.Repository
{
    public abstract class BaseRepository<T> : IRepository<T> where T : Entity, new()
    {
        protected readonly MinhaApiDbContext _dbContext;
        protected readonly DbSet<T> _dbSet;

        protected BaseRepository(MinhaApiDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
