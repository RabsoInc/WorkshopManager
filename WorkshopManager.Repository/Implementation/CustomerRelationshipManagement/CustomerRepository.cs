using Microsoft.EntityFrameworkCore;
using WorkshopManager.DataServices;
using WorkshopManager.Models.CustomerRelationshipManagement.BaseModels;
using WorkshopManager.Repository.Implementation.Global;
using WorkshopManager.Repository.IRepository.CustomerRelationshipManagement;

namespace WorkshopManager.Repository.Implementation.CustomerRelationshipManagement
{
    public class CustomerRepository : Repository<Customer>, ICustomer
    {
        private readonly ApplicationDbContext db;

        public CustomerRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public Customer TestExtract(Guid Id)
        {
            return db.Customers.Where(x => x.Id == Id).Include("Gender").Include("Title,Gender").FirstOrDefault();
        }

        public void UpdateRecord(Customer obj)
        {
            db.Update(obj);
        }
    }
}

