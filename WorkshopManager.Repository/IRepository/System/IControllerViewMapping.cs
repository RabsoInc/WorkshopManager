using WorkshopManager.Models.System.BaseModels;
using WorkshopManager.Repository.IRepository.Global;

namespace WorkshopManager.Repository.IRepository.System
{
    public interface IControllerViewMapping : IRepository<ControllerViewMapping>
    {
        void UpdateRecord(ControllerViewMapping obj);
    }
}
