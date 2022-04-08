using WorkshopManager.Models.CustomerRelationshipManagement.BaseModels;
using WorkshopManager.Repository.IRepository.Global;

namespace WorkshopManager.Repository.IRepository.CustomerRelationshipManagement
{
    public interface ICustomer : IRepository<Customer>
    {
        void UpdateRecord(Customer obj);
        public Customer TestExtract(Guid Id);
    }
}
