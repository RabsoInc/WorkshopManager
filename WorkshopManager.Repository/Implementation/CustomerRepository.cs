using WorkshopManager.DataServices;
using WorkshopManager.Models.CustomerRelationshipManagement.BaseModels;
using WorkshopManager.Models.System.BaseModels;
using WorkshopManager.Repository.IRepository;

namespace WorkshopManager.Repository.Implementation
{
    public class CustomerRepository : Repository<Customer>, ICustomer
    {
        private readonly ApplicationDbContext db;

        public CustomerRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public void UpdateRecord(ReleaseNote obj)
        {
            db.Update(obj);
        }
    }
}

