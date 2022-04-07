using WorkshopManager.Models.CustomerRelationshipManagement.BaseModels;
using WorkshopManager.Models.System.BaseModels;
using WorkshopManager.Repository.IRepository.Global;

namespace WorkshopManager.Repository.IRepository.CustomerRelationshipManagement
{
    public interface ICustomer : IRepository<Customer>
    {
        void UpdateRecord(ReleaseNote obj);
    }
}
