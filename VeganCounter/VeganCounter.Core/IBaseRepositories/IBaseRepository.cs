using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VeganCounter.Core.BaseEntities;

namespace VeganCounter.Core.IBaseRepositories
{
    public interface IBaseRepository<TEntity>where TEntity:BaseEntity
    {
        TEntity? Create(TEntity entity);

        TEntity? Update(TEntity entity);

        /// <summary>
        /// değer döndürmesinin sebebi yaptığımız işlem de değer döndüreceği içindir.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Delete(TEntity entity);

        bool Any(Expression<Func<TEntity, bool>> filter);

        TEntity? GetFirstOrDefault(Expression<Func<TEntity, bool>> filter);

        ICollection<TEntity>? GetAll(Expression<Func<TEntity, bool>> filter);

        TResult? GetFiltredFirstOrDefault<TResult>(Expression<Func<TEntity, TResult>> select,
                                                   Expression<Func<TEntity, bool>> where,
                                                   Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
                                                   params Expression<Func<TEntity, object>>[] inculudes);

        ICollection<TResult>? GetFilteredList<TResult>(Expression<Func<TEntity, TResult>> select,
                                                       Expression<Func<TEntity, bool>> where,
                                                       Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
                                                       params Expression<Func<TEntity, object>>[] includes);
    }
}
