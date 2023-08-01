using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyDotnetCoreVersionNugetPackage.Models
{
    public static class MyModel
    {
        public static async Task<List<TSource>> TestMethodAsync<TSource>(this IQueryable<TSource> source, CancellationToken cancellationToken = default)
        {
            return await source.ToListAsync(cancellationToken);
        }

        public static IQueryable<TSource> TestMethod<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return source.Where(predicate);
        }
    }
}
