using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace erpApp.Model
{
  public interface IRepository<TEntity> where TEntity : class
  {
    IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        string includeProperties = "");
    TEntity GetById(params object[] keyValues);
    void Insert(TEntity entity);
    void Delete(params object[] keyValues);
    void Delete(TEntity entityToDelete);
    void Update(TEntity entity);
    void Save();
  }
}
