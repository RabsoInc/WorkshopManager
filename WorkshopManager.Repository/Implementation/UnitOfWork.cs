using WorkshopManager.DataServices;
using WorkshopManager.Repository.IRepository;

namespace WorkshopManager.Repository.Implementation
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
        }

        //Interface Registration
        public ICustomer CustomerRepository { get; private set; }
        public IReleaseNote ReleaseNoteRepository { get; private set; }

        //Global Methods
        public void UpdateDatabase()
        {
            db.SaveChanges();
        }
    }
}
