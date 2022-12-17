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
    public class EmergencyContactDal:IEntityDal<EmergencyContact>
    {
        public void Add(EmergencyContact items)
        {
            using (DormProjectConctex context = new DormProjectConctex())
            {
                var addeditem = context.Entry(items);
                addeditem.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public List<EmergencyContact> GetAll(Expression<Func<EmergencyContact, bool>> filter = null)
        {
            using (DormProjectConctex context = new DormProjectConctex())
            {
                return filter == null ? context.Set<EmergencyContact>().ToList() : context.Set<EmergencyContact>().Where(filter).ToList();
            }
        }

        public void Delete(EmergencyContact items)
        {
            using (DormProjectConctex context = new DormProjectConctex())
            {
                var deletedItem = context.Entry(items);
                deletedItem.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(EmergencyContact items)
        {
            using (DormProjectConctex context = new DormProjectConctex())
            {
                var updatedItem = context.Entry(items);
                updatedItem.State = EntityState.Modified;
                context.SaveChanges();


            }
        }
        public EmergencyContact Get(Expression<Func<EmergencyContact, bool>> filter)
        {
            using (DormProjectConctex context = new DormProjectConctex())
            {
                return context.Set<EmergencyContact>().SingleOrDefault(filter);
            }
        }
    
}
}
