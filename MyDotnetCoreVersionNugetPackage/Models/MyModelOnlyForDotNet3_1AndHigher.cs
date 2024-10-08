﻿#if NETCOREAPP3_1_OR_GREATER
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.EntityFrameworkCore;

namespace MyDotnetCoreVersionNugetPackage.Models
{
    public static class MyModelOnlyForDotNet3_1AndHigher
    {
        /// <summary>
        /// TestMethodAsync3_1
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<List<TSource>> TestMethodAsync3_1<TSource>(this IQueryable<TSource> source, CancellationToken cancellationToken = default)
        {
            return await source.ToListAsync(cancellationToken);
        }
    }
}
#endif