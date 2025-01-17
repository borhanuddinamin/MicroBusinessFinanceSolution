using Microsoft.EntityFrameworkCore;
using MBS.DAL.Data;
using MBS.DAL.Repository.IRpository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MBS.DAL.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;

        public Repository(ApplicationDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
        }
        public void Add(T entity)
        {
           dbSet.Add(entity);
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = dbSet;
            return query.ToList();
        }

        public IEnumerable<T> GetAllById(Expression<Func<T, bool>> filter, string? includeproperties = null)
        {
            IQueryable<T> query = dbSet;
            if (includeproperties != null)
            {
                foreach (var inclueprop in includeproperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(inclueprop);
                }
                query = query.Where(filter);
            }
            
            return query.ToList();
        }
        public IEnumerable<T> GetAllByIds(IEnumerable<int> ids, string? includeProperties = null)
        {
            if (ids == null || !ids.Any())
            {
                throw new ArgumentException("The list of IDs cannot be null or empty.", nameof(ids));
            }

            IQueryable<T> query = dbSet;

            // Include navigation properties if specified
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }

            // Use reflection to get the 'Id' property
            var parameter = Expression.Parameter(typeof(T), "entity");
            var property = Expression.Property(parameter, "Id");
            var containsMethod = typeof(Enumerable).GetMethods()
                .First(m => m.Name == "Contains" && m.GetParameters().Length == 2)
                .MakeGenericMethod(typeof(int));
            var idsExpression = Expression.Constant(ids);
            var containsExpression = Expression.Call(containsMethod, idsExpression, property);
            var lambda = Expression.Lambda<Func<T, bool>>(containsExpression, parameter);

            query = query.Where(lambda);

            return query.ToList();
        }




        public T GetFirstOrDefault(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;
            query=query.Where(filter);
            return query.FirstOrDefault();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
           dbSet.RemoveRange(entities);
        }
    }
}
