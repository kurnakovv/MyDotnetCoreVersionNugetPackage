﻿#if NET5_0_OR_GREATER
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.EntityFrameworkCore;

namespace MyDotnetCoreVersionNugetPackage.Models
{
    public static class MyModelOnlyForDotNet5AndHigher
    {
        public static async Task<List<TSource>> TestMethodAsync5<TSource>(this IQueryable<TSource> source, CancellationToken cancellationToken = default)
        {
            return await source.ToListAsync(cancellationToken);
        }
    }
}
#endif