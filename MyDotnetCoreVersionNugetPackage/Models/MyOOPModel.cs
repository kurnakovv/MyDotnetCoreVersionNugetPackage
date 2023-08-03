using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDotnetCoreVersionNugetPackage.Models
{
    public class MyOOPModel<TEntity> where TEntity : class
    {
        private readonly DbSet<TEntity> _entities;
        private readonly DbContext _dbContext;

        public MyOOPModel(
            DbSet<TEntity> entities,
            DbContext dbContext)
        {
            _entities = entities;
            _dbContext = dbContext;
        }

        public void Do(TEntity entity)
        {
            _entities.Add(entity);
        }

        public void Add(TEntity entity)
        {
            _dbContext.Add(entity);
        }
    }

    public class A
    {
        private readonly AppDbContext _appDbContext;

        public A(
            AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void M()
        {
            new MyOOPModel<B>(_appDbContext.Bs, _appDbContext);
        }
    }
}
