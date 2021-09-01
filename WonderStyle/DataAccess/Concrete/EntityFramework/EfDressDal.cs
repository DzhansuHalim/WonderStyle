using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDressDal : IDressDal
    {
        public void Create(Dress entity)
        {
            using (WonderStyleContext context = new WonderStyleContext() )
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Dress entity)
        {
            using (WonderStyleContext context = new WonderStyleContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Dress Get(Expression<Func<Dress, bool>> filter)
        {
            using (WonderStyleContext context = new WonderStyleContext())
            {
                return context.Set<Dress>().SingleOrDefault(filter);
            }
        }

        public List<Dress> GetAll(Expression<Func<Dress, bool>> filter = null)
        {
            using (WonderStyleContext context = new WonderStyleContext())
            {
                return filter == null
                    ? context.Set<Dress>().ToList()
                    : context.Set<Dress>().Where(filter).ToList();
            }
        }

        public void Update(Dress entity)
        {
            using (WonderStyleContext context = new WonderStyleContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
