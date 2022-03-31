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
            SystemAttributeRepository = new SystemAttributeRepository(db);
            ReleaseNoteRepository = new ReleaseNoteRepository(db);
        }

        //Interface Registration
        public ISystemAttribute SystemAttributeRepository { get; private set; }
        public IReleaseNote ReleaseNoteRepository { get; private set; }

        //Global Methods
        public void UpdateDatabase()
        {
            db.SaveChanges();
        }
    }
}
