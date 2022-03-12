﻿using asp_net_core_Unitofwork_with_Repository_pattern.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace asp_net_core_Unitofwork_with_Repository_pattern.Persistence
{
	public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
	{
        protected readonly DbContext Context;
        protected readonly DbSet<TEntity> DbSetEntity;

        public Repository(DbContext context)
        {
            Context = context;
            DbSetEntity = Context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            DbSetEntity.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            DbSetEntity.AddRange(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSetEntity.Where(predicate);
        }

        public TEntity Get(int id)
        {
            return DbSetEntity.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DbSetEntity.ToList();
        }

        public void Remove(TEntity entity)
        {
            DbSetEntity.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            DbSetEntity.RemoveRange(entities);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSetEntity.SingleOrDefault(predicate);
        }
    }
}