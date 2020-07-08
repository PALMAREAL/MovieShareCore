using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MovieShareCore.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private ApplicationDbContext DbContext;
        private DbSet<TEntity> dbSet;

        public Repository(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
            dbSet = dbContext.Set<TEntity>();
        }

        public async virtual Task<IEnumerable<TEntity>> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return await Task.Run<IEnumerable<TEntity>>(() => orderBy(query).ToList());
            }
            else
            {
                return await Task.Run<IEnumerable<TEntity>>(() => query.ToList());
            }
        }

        public async virtual Task<TEntity> GetById(object id)
        {
            return await dbSet.FindAsync(id);
        }

        public async virtual Task Insert(TEntity entity)
        {
           await dbSet.AddAsync(entity);
        }

        public async virtual Task Delete(object id)
        {
            var entity = dbSet.FindAsync(id);

            await Delete(entity.Result);
        }

        public async virtual Task Delete(TEntity entity)
        {
            if (DbContext.Entry(entity).State == EntityState.Detached)
                dbSet.Attach(entity);

            await Task.Run(() => dbSet.Remove(entity));
        }

        public async virtual Task Update(TEntity entity)
        {
            await Task.Run(() =>
            {  
                dbSet.Attach(entity);
                DbContext.Entry(entity).State = EntityState.Modified;
            }); 
        }
    }
}
