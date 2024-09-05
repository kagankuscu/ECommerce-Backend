using System.Linq.Expressions;
using ECommerce.DataAccess;
using ECommerce.Models.Models;
using ECommerce.Repository.Shared.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Repository.Shared.Concrete;
public class Repository<T> : IRepository<T> where T : BaseModel
{
    private readonly ApplicationDbContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(ApplicationDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public bool Add(T entity)
    {
        try
        {
            _dbSet.Add(entity);
            Save();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool AddRange(IEnumerable<T> entities)
    {
        try
        {
            _dbSet.AddRange(entities);
            Save();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public IQueryable<T> GetAll() => _dbSet.Where(x => !x.IsDelete);

    public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate) => _dbSet.Where(predicate);

    public IQueryable<T> GetAllDeleted() => _dbSet.Where(x => x.IsDelete);

    public IQueryable<T> GetAllDeleted(Expression<Func<T, bool>> filter) => _dbSet.Where(x => x.IsDelete).Where(filter);

    public T? GetById(int id) => _dbSet.FirstOrDefault(x => x.Id == id);

    public T? GetById(Guid id) => _dbSet.FirstOrDefault(x => x.Guid == id);

    public T? GetFirstOrDefault(Expression<Func<T, bool>> predicate) => _dbSet.FirstOrDefault(predicate);

    public bool Remove(T entity)
    {
        try
        {
            entity.IsDelete = true;
            entity.IsActive = false;
            entity.DateModified = DateTime.Now;
            _dbSet.Update(entity);
            Save();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool Remove(Guid guid)
    {
        try
        {
            T? entity = GetById(guid);
            if (entity is null)
                return false;
            Remove(entity);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool Remove(int id)
    {
        try
        {
            T? entity = GetById(id);
            if (entity is null)
                return false;
            Remove(entity);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool RemoveRange(IEnumerable<T> entities)
    {
        try
        {
            foreach (T entity in entities)
            {
                entity.IsDelete = true;
                entity.IsActive = false;
                entity.DateModified = DateTime.Now;
            }
            _dbSet.UpdateRange(entities);
            Save();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public void Save() => _context.SaveChanges();

    public bool Update(T entity)
    {
        try
        {
            entity.DateModified = DateTime.Now;
            _dbSet.Update(entity);
            Save();
            return true;
        }
        catch
        {
            return false;
        }
    }
}
