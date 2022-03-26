using WorkshopManager.DataServices;
using WorkshopManager.Models.System.BaseModels;
using WorkshopManager.Repository.IRepository;

namespace WorkshopManager.Repository.Implementation
{
    public class SystemAttributeRepository
        : Repository<SystemAttribute>, ISystemAttribute
    {
        private readonly ApplicationDbContext db;

        public SystemAttributeRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public void UpdateRecord(SystemAttribute obj)
        {
            db.Update(obj);
        }
    }
}
