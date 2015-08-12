using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Trails6Repo.Data
{
   public static class GenericRepositoryExtensions
    {
       public static IQueryable<T> Include<T, TProperty>(this IQueryable<T> queryable, Expression<Func<T, TProperty>> relatedEntity) where T : class
       {
           return System.Data.Entity.QueryableExtensions.Include<T, TProperty>(queryable, relatedEntity);
       }
    }
}
