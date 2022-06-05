using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface IRepository<T>
    {
        T Get(Expression<Func<T, bool>> filter);
        void Delete(T p);
        void Insert(T p);
        void Update(T p);

        List<T> List();
        List<T> List(Expression<Func<T,bool>>filter);

    }
}
