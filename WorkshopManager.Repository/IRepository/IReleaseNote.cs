using WorkshopManager.Models.System.BaseModels;

namespace WorkshopManager.Repository.IRepository
{
    public interface IReleaseNote : IRepository<ReleaseNote>
    {
        void UpdateRecord(ReleaseNote obj);
        ReleaseNote GetLatestReleaseNote();
    }
}
