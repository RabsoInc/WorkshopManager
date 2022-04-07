using WorkshopManager.Models.System.BaseModels;
using WorkshopManager.Repository.IRepository.Global;

namespace WorkshopManager.Repository.IRepository.System
{
    public interface IReleaseNote : IRepository<ReleaseNote>
    {
        void UpdateRecord(ReleaseNote obj);
        ReleaseNote GetLatestReleaseNote();
    }
}
