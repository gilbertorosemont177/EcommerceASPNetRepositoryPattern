using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
namespace DatabaseCnX.Core.Repositories
{
    //generic Interface
    public interface IRepository<TEntity> where TEntity : class
    {

        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity,bool>> predicate);

        TEntity singleOrDefault(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity te);
        void Remove(TEntity te);
        void AddRange(IEnumerable<TEntity>entities);
        void DeleteRange(IEnumerable<TEntity> entities);
       


    }
}
