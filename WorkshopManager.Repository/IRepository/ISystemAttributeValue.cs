using WorkshopManager.Models.System.BaseModels;

namespace WorkshopManager.Repository.IRepository
{
    public interface ISystemAttributeValue : IRepository<SystemAttributeValue>
    {
        void UpdateRecord(SystemAttributeValue obj);
    }
}
