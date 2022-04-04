using WorkshopManager.DataServices;
using WorkshopManager.Models.System.BaseModels;
using WorkshopManager.Repository.IRepository;

namespace WorkshopManager.Repository.Implementation
{
    public class SystemAttributeValueRepository
        : Repository<SystemAttributeValue>, ISystemAttributeValue
    {
        private readonly ApplicationDbContext db;

        public SystemAttributeValueRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public void UpdateRecord(SystemAttributeValue obj)
        {
            db.Update(obj);
        }
    }
}
