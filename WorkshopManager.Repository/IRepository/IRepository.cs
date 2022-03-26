using System.Linq.Expressions;

namespace WorkshopManager.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T GetSingleRecord(Expression<Func<T,bool>> filter);
        IEnumerable<T> GetAllRecords();
        void CreateRecord(T entity);
        void DeleteRecord(T entity);
        void RemoveMultipleRecords(IEnumerable<T> entities);

    }
}
