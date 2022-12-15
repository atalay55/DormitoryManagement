using DormitoryManagement.Enitity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DormitoryManagement.DataAccess.Abstract
{
    public interface IEntityDal<T> where T : IEntity
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T items);
        void Delete(T items);
        void Update(T items);
    }
}
