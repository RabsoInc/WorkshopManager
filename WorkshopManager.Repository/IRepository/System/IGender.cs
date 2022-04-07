using WorkshopManager.Models.System.BaseModels;
using WorkshopManager.Repository.IRepository.Global;

namespace WorkshopManager.Repository.IRepository.System
{
    public interface IGender : IRepository<Gender>
    {
        void UpdateRecord(Gender obj);
    }
}
