using DormitoryManagement.DataAccess.Abstract;
using DormitoryManagement.Enitity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DormitoryManagement.DataAccess.Concrete
{
    public class ParentDal : IEntityDal<Parent>
    {
        public void Add(Parent items)
        {
            using (DormProjectConctex context = new DormProjectConctex())
            {
                var addeditem = context.Entry(items);
                addeditem.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public List<Parent> GetAll(Expression<Func<Parent, bool>> filter = null)
        {
            using (DormProjectConctex context = new DormProjectConctex())
            {
                return filter == null ? context.Set<Parent>().ToList() : context.Set<Parent>().Where(filter).ToList();
            }
        }

        public void Delete(Parent items)
        {
            using (DormProjectConctex context = new DormProjectConctex())
            {
                var deletedItem = context.Entry(items);
                deletedItem.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(Parent items)
        {
            using (DormProjectConctex context = new DormProjectConctex())
            {
                var updatedItem = context.Entry(items);
                updatedItem.State = EntityState.Modified;
                context.SaveChanges();


            }
        }
        public Parent Get(Expression<Func<Parent, bool>> filter)
        {
            using (DormProjectConctex context = new DormProjectConctex())
            {
                return context.Set<Parent>().SingleOrDefault(filter);
            }
        }
    }
}
