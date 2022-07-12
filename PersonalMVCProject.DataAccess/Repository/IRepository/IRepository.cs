using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

//Generic repository that will provide the services that all items use, not ones that are specific to certain elements

namespace PersonalMVCProject.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        //T - Category (for now)
        T GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProperties = null);
        IEnumerable<T> GetAll(string? includeProperties = null);
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);

    }
}
