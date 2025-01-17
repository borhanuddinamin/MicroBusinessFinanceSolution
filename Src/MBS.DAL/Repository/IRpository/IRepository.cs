using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MBS.DAL.Repository.IRpository
{
    public interface IRepository<T> where T : class 
    {
        IEnumerable<T> GetAll();
        void Add(T entity);
        T GetFirstOrDefault(Expression<Func<T, bool>> filter);
        IEnumerable<T> GetAllById(Expression<Func<T, bool>> filter, string? includeproperties = null);
        IEnumerable<T> GetAllByIds(IEnumerable<int> ids, string? includeProperties = null);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
    
}
