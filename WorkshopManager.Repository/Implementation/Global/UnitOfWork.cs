using WorkshopManager.DataServices;
using WorkshopManager.Repository.Implementation.CustomerRelationshipManagement;
using WorkshopManager.Repository.Implementation.System;
using WorkshopManager.Repository.IRepository.CustomerRelationshipManagement;
using WorkshopManager.Repository.IRepository.Global;
using WorkshopManager.Repository.IRepository.System;

namespace WorkshopManager.Repository.Implementation.Global
{
    public class UnitOfWork : IUnitOfWork
    {
        //Constructor and Initalisation
        private readonly ApplicationDbContext db;

        public UnitOfWork(ApplicationDbContext db)
        {
            this.db = db;
            ReleaseNoteRepository = new ReleaseNoteRepository(db);
            CustomerRepository = new CustomerRepository(db);
            ControllerViewMappingRepository = new ControllerViewMappingRepository(db);
        }

        //Interface Registration
        public IControllerViewMapping ControllerViewMappingRepository { get; private set; }
        public ICustomer CustomerRepository { get; private set; }
        public IReleaseNote ReleaseNoteRepository { get; private set; }

        //Global Methods
        public void UpdateDatabase()
        {
            db.SaveChanges();
        }
    }
}
