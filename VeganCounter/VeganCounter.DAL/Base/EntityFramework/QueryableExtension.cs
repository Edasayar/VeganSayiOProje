using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace VeganCounter.DAL.Base.EntityFramework
{
    public static class QueryableExtension
    {
        /// <summary>
        /// Aggregate=Lınque özelliğidir.Buraya bir liste gelir ve dışarıdan gelen bir b querysi eklenir.Yani listede var olan a ya b eklenir.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        public static IQueryable<T> MyIncludes<T>(this IQueryable<T> query, params Expression<Func<T, object>>[] includes)
            where T : class
        {
            if (query != null)
            {
                query = includes.Aggregate(query, (a, b) => a.Include(b));
            }

            return query;
        }
    }
}
