using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WorkshopManager.DataServices;
using WorkshopManager.Repository.IRepository;

namespace WorkshopManager.Repository.Implementation
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext db;
        internal DbSet<T> dbSet;

        public Repository(ApplicationDbContext db)
        {
            this.db = db;
            this.dbSet = db.Set<T>();
        }

        public void CreateRecord(T entity)
        {
            dbSet.Add(entity);
        }

        public void DeleteRecord(T entity)
        {
            dbSet.Remove(entity);
        }

        public IEnumerable<T> GetAllRecords()
        {
            IQueryable<T> query = dbSet;
            return query.ToList();
        }

        public T GetSingleRecord(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;
            query = query.Where(filter);
            return query.FirstOrDefault();
        }

        public void RemoveMultipleRecords(IEnumerable<T> entities)
        {
            dbSet.RemoveRange(entities);
        }
    }
}
