using WorkshopManager.Models.System.BaseModels;
using WorkshopManager.Repository.IRepository.Global;

namespace WorkshopManager.Repository.IRepository.System
{
    public interface ITitle : IRepository<Title>
    {
        void UpdateRecord(Title obj);
    }
}
