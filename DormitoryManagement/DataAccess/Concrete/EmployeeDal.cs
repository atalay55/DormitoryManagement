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
    public class EmployeeDal : IEntityDal<Employee>
    {
        public void Add(Employee items)
        {
            using (DormProjectConctex context = new DormProjectConctex())
            {
                var addeditem = context.Entry(items);
                addeditem.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public List<Employee> GetAll(Expression<Func<Employee, bool>> filter = null)
        {
            using (DormProjectConctex context = new DormProjectConctex())
            {
                return filter == null ? context.Set<Employee>().ToList() : context.Set<Employee>().Where(filter).ToList();
            }
        }

        public void Delete(Employee items)
        {
            using (DormProjectConctex context = new DormProjectConctex())
            {
                var deletedItem = context.Entry(items);
                deletedItem.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(Employee items)
        {
            using (DormProjectConctex context = new DormProjectConctex())
            {
                var updatedItem = context.Entry(items);
                updatedItem.State = EntityState.Modified;
                context.SaveChanges();


            }
        }
        public Employee Get(Expression<Func<Employee, bool>> filter)
        {
            using (DormProjectConctex context = new DormProjectConctex())
            {
                return context.Set<Employee>().SingleOrDefault(filter);
            }
        }
    }
}
