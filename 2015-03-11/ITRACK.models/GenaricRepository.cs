using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public  class GenaricRepository<TEntity> : IGenaricRepository<TEntity> where TEntity : class
    {
       /// <summary>
       /// 
       /// </summary>
       protected DbSet<TEntity> DbSet;
       /// <summary>
       /// 
       /// </summary>
       private readonly DbContext _dbContext;

       /// <summary>
       /// 
       /// </summary>
       /// <param name="dbContext"></param>
       public GenaricRepository(DbContext dbContext) {

           _dbContext = dbContext;
           DbSet = _dbContext.Set<TEntity>();
       }
       /// <summary>
       /// 
       /// </summary>
       public GenaricRepository() { 
       
       }


       /// <summary>
       /// find entity by id with wait 
       /// </summary>
       /// <param name="Id"> Record ID</param>
       /// <returns> DbSet</returns>
        public async Task<TEntity> GetIdByAsync(int Id)
        {
            return await DbSet.FindAsync(Id); 
        }
       

       /// <summary>
       /// 
       /// </summary>
       /// <param name="predicate"></param>
       /// <returns></returns>
        public IQueryable<TEntity> SearchFor(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }


       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
        public IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }


       /// <summary>
       /// 
       /// </summary>
       /// <param name="entity"></param>
       /// <returns></returns>
        public async Task EditAsync(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="entity"></param>
       /// <returns></returns>
        public async Task AddAsync(TEntity entity)
        {
             DbSet.Add(entity);
             await _dbContext.SaveChangesAsync();

        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="entity"></param>
       /// <returns></returns>
        public async Task DeleteAsync(TEntity entity)
        {
            DbSet.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
