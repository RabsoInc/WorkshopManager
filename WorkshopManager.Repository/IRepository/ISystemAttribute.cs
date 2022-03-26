using WorkshopManager.Models.System.BaseModels;

namespace WorkshopManager.Repository.IRepository
{
    public interface ISystemAttribute : IRepository<SystemAttribute>
    {
        void UpdateRecord(SystemAttribute obj);
    }
}
