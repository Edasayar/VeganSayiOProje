using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VeganCounter.Core.BaseEntities;
using VeganCounter.Core.Enums;
using VeganCounter.Core.IBaseRepositories;

//Farklı bir database kullanmak istersek eğer diye entity framework klasörü oluşturuldu.abstract olmasının sebebi ise hiç yenilenmeyecek olmasıdırır.
namespace VeganCounter.DAL.Base.EntityFramework
{
    public abstract class BaseRepository<TEntity, TContext> : IBaseRepository<TEntity>
        where TEntity : BaseEntity
        where TContext : DbContext
    {
        /// <summary>
        /// Readonly=> Bir kere tanımlanır.Bunlar ise ctor içine gevşek bağlılık yani depencyenjection kullanarak bağlarız.
        /// </summary>
        protected readonly TContext _db;
        protected readonly DbSet<TEntity> _dbSet;
        public BaseRepository(TContext context)
        {
            _db = context;
            _dbSet = _db.Set<TEntity>();
        }
        public bool Any(Expression<Func<TEntity, bool>> filter)
        {
            return _dbSet.Any(filter);
        }

        /// <summary>
        /// save change bize int değer döndürür.Kaç satır yaptığım kaç satır etkilenmiş.Kaç tane satır bundan etkilenmiş onu gösterir.Etkilenen satır sayısının >0 dan büyükse entity döndürür küçük ise null değerini döndürür.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public TEntity? Create(TEntity entity)
        {
            _db.Entry(entity).State = EntityState.Added;
            
            return _db.SaveChanges() > 0 ? entity : null;
        }

        /// <summary>
        /// bool kullanmamız gerekir ve silmek istediğimiz entity yapısını görmek isteriz.
        /// typeoff=Hangi tür entity döndürdüğümüzü gösterir.DeletedDate ise property var mı diye bakarız.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Delete(TEntity entity)
        {
            bool hasProperty = HasOwnProperty(typeof(TEntity), "DeleteDate");

            if (!hasProperty)
            {
                entity.State = State.Deleted;
                TEntity statedEntity = Update(entity);
                return statedEntity != null ;
            }
            else 
            {
                _db.Entry(entity).State = EntityState.Deleted;
                return _db.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// Bu private metodu yazılır ve delete işleminde kullanılır.type adındaki class çok kullanılmasa da oldukça yararlı bir classtır.
        /// </summary>
        /// <param name="entityType"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        private bool HasOwnProperty(Type entityType, string propertyName)
        {
            var properties = entityType.GetProperties();
            bool hasproperty = properties.Any(p => p.Name == propertyName);
            return hasproperty;
        }

        public ICollection<TEntity>? GetAll(Expression<Func<TEntity, bool>> filter)
        {
            return _dbSet.Where(filter).ToList();
        }

        /// <summary>
        /// bu ifadeye Iqueryble alırız db set atamasını yaparız.
        /// QueryableExtension sınıfının açılmasının sebebi buraya eklemek için static clas olması gerekir.
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="select"></param>
        /// <param name="where"></param>
        /// <param name="orderBy"></param>
        /// <param name="inculudes"></param>
        /// <returns></returns>
        public ICollection<TResult>? GetFilteredList<TResult>(Expression<Func<TEntity, TResult>> select, Expression<Func<TEntity, bool>> where, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, params Expression<Func<TEntity, object>>[] inculudes)
        {
            IQueryable<TEntity> query = _dbSet;

            if (where != null)
            {
                query = query.Where(where);
            }
            if (inculudes != null)
            {
                query = query.MyIncludes(inculudes);
            }

            if (orderBy != null)
            {
                return orderBy(query).Select(select).ToList();
            }
            else
            {
                return query.Select(select).ToList();
            }
        }

        public TResult? GetFiltredFirstOrDefault<TResult>(Expression<Func<TEntity, TResult>> select, Expression<Func<TEntity, bool>> where, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, params Expression<Func<TEntity, object>>[] inculudes)
        {
            IQueryable<TEntity> query = _dbSet;

            if (where != null)
            {
                query = query.Where(where);
            }

            if (inculudes != null)
            {
                query = query.MyIncludes(inculudes);
            }

            if (orderBy != null)
            {
                return orderBy(query).Select(select).FirstOrDefault();
            }

            return query.Select(select).FirstOrDefault();
        }

        public TEntity? GetFirstOrDefault(Expression<Func<TEntity, bool>> filter)
        {
            return _dbSet.FirstOrDefault(filter);
        }

        /// <summary>
        /// Bu metotta sıfırdan büyük değil ise bana null değerini döndürür.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public TEntity? Update(TEntity entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            return _db.SaveChanges() > 0 ? entity : null;
        }
        
    }

}

