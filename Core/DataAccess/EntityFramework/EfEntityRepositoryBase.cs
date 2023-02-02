using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
         where TEntity : class, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }  
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var DelEntity = context.Entry(entity);
                DelEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get()
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault();
            }
        }

        public List<TEntity> GetAll()
        {
            using (TContext context = new TContext())
            {
              return context.Set<TEntity>().ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var UpdatedEntity = context.Entry(entity);
                UpdatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
