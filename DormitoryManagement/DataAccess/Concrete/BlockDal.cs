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
    public class BlockDal : IEntityDal<Block>
    {
        public void Add(Block items)
        {
            using (DormProjectConctex context = new DormProjectConctex())
            {
                var addeditem = context.Entry(items);
                addeditem.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public List<Block> GetAll(Expression<Func<Block, bool>> filter = null)
        {
            using (DormProjectConctex context = new DormProjectConctex())
            {
                return filter == null ? context.Set<Block>().ToList() : context.Set<Block>().Where(filter).ToList();
            }
        }

        public void Delete(Block items)
        {
            using (DormProjectConctex context = new DormProjectConctex())
            {
                var deletedItem = context.Entry(items);
                deletedItem.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(Block items)
        {
            using (DormProjectConctex context = new DormProjectConctex())
            {
                var updatedItem = context.Entry(items);
                updatedItem.State = EntityState.Modified;
                context.SaveChanges();


            }
        }
        public Block Get(Expression<Func<Block, bool>> filter)
        {
            using (DormProjectConctex context = new DormProjectConctex())
            {
                return context.Set<Block>().SingleOrDefault(filter);
            }
        }
    }
}
