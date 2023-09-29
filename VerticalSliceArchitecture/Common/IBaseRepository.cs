using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;
using VerticalSliceArchitecture.Domain;

namespace VerticalSliceArchitecture.Common
{
    public interface IBaseRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T GetById(int id);
        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);
    }
}
