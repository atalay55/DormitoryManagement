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

    public class StudentDal : IEntityDal<Student>
    {
        public void Add(Student items)
        {
        
            using (DormProjectConctex context = new DormProjectConctex())
            {
                
                var addeditem = context.Entry(items);
                addeditem.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public List<Student> GetAll(Expression<Func<Student, bool>> filter = null)
        {
            using (DormProjectConctex context = new DormProjectConctex())
            {

                return filter == null ? context.Set<Student>().ToList() : context.Set<Student>().Where(filter).ToList();
            }
        }

        public void Delete(Student items)
        {
            using (DormProjectConctex context = new DormProjectConctex())
            {
                var deletedItem = context.Entry(items);
                deletedItem.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(Student items)
        {
            using (DormProjectConctex context = new DormProjectConctex())
            {
                var updatedItem = context.Entry(items);
                updatedItem.State = EntityState.Modified;
                context.SaveChanges();


            }
        }
        public Student Get(Expression<Func<Student, bool>> filter)
        {
            using (DormProjectConctex context = new DormProjectConctex())
            {
                return context.Set<Student>().SingleOrDefault(filter);
            }
        }

        public Room GetRoom(Expression<Func<Room, bool>> filter)
        {
            using (DormProjectConctex context = new DormProjectConctex())
            {
                return context.Set<Room>().SingleOrDefault(filter);
            }
        }

        public Block GetBlock(Expression<Func<Block, bool>> filter)
        {
            using (DormProjectConctex context = new DormProjectConctex())
            {
                return context.Set<Block>().SingleOrDefault(filter);
            }
        }
    }
}
