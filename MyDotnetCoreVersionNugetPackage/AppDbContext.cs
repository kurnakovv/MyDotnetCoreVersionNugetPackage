﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDotnetCoreVersionNugetPackage
{
    public class AppDbContext : DbContext
    {
        public DbSet<B> Bs { get; set; }
    }

    public class B
    {

    }
}
