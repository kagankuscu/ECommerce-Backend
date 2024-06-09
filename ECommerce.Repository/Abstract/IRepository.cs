using System.Linq.Expressions;
using ECommerce.Models.Models;

namespace ECommerce.Repository.Abstract;
public interface IRepository<T> where T : BaseModel 
{
    bool Add(T entity);
    bool AddRange(IEnumerable<T> entities);

    bool Update(T entity);

    bool Remove(T entity);
    bool Remove(Guid guid);
    bool Remove(int id);
    bool RemoveRange(IEnumerable<T> entities);

    IQueryable<T> GetAll();
    IQueryable<T> GetAll(Expression<Func<T, bool>> predicate);
    IQueryable<T> GetAllDeleted();
    IQueryable<T> GetAllDeleted(Expression<Func<T, bool>> filter);
    T? GetById(int id);
    T? GetById(Guid id);
    T? GetFirstOrDefault(Expression<Func<T, bool>> predicate);

    void Save();

}