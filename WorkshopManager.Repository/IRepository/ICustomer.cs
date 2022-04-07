using WorkshopManager.Models.CustomerRelationshipManagement.BaseModels;
using WorkshopManager.Models.System.BaseModels;

namespace WorkshopManager.Repository.IRepository
{
    public interface ICustomer : IRepository<Customer>
    {
        void UpdateRecord(ReleaseNote obj);
    }
}
