using Microsoft.EntityFrameworkCore;
using ProductUnluCo.Domain.Interface;
using ProductUnluCo.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProductUnluCo.Infrastructure.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity, new()
    {
        ProductDbContext _context;
        private DbSet<TEntity> _entity;
        public Repository(ProductDbContext context)
        {
            _context = context;
            _entity = _context.Set<TEntity>();
        }

        public async Task Add(TEntity entity)
        {
            await _entity.AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            _entity.Remove(entity);
        }

        public async Task<List<TEntity>> Get(Expression<Func<TEntity, bool>> filter)
        {
            return await _entity.Where(filter).ToListAsync();
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _entity.ToListAsync();
        }

        public void Update(TEntity entity)
        {
            _entity.Update(entity);
        }
    }
}

