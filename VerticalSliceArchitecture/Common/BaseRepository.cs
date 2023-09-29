using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;
using VerticalSliceArchitecture.Data;
using VerticalSliceArchitecture.Domain;

namespace VerticalSliceArchitecture.Common
{
    public class BaseRepository<TEntity, TContext> : IBaseRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : ApplicationContext
    {
        private readonly TContext _context;
        public BaseRepository(TContext context)
        {
            _context= context;
        }


        public TEntity Add(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Added;
            _context.SaveChanges();
            return entity;
        }

        public TEntity Delete(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
            _context.SaveChanges();
            return entity;
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? _context.Set<TEntity>().ToList() : _context.Set<TEntity>().Where(filter).ToList();
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public TEntity Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return entity;
        }
    }
}
