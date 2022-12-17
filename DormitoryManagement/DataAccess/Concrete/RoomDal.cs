
using DormitoryManagement.DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DormitoryManagement.DataAccess.Concrete
{
    public class RoomDal : IEntityDal<Room>
    {
        public void Add(Room items)
        {
            using (DormProjectConctex context = new DormProjectConctex())
            {
                var addeditem = context.Entry(items);
                addeditem.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public List<Room> GetAll(Expression<Func<Room, bool>> filter = null)
        {
            using (DormProjectConctex context = new DormProjectConctex())
            {
                return filter == null ? context.Set<Room>().ToList() : context.Set<Room>().Where(filter).ToList();
            }
        }

        public void Delete(Room items)
        {
            using (DormProjectConctex context = new DormProjectConctex())
            {
                var deletedItem = context.Entry(items);
                deletedItem.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(Room items)
        {
            using (DormProjectConctex context = new DormProjectConctex())
            {
                var updatedItem = context.Entry(items);
                updatedItem.State = EntityState.Modified;
                context.SaveChanges();


            }
        }
        public Room Get(Expression<Func<Room, bool>> filter)
        {
            using (DormProjectConctex context = new DormProjectConctex())
            {
                return context.Set<Room>().SingleOrDefault(filter);
            }
        }
    }
}
