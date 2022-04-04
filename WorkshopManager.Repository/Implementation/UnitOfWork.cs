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
            SystemAttributeRepository = new SystemAttributeRepository(db);
            SystemAttributeValueRepository = new SystemAttributeValueRepository(db);
        }

        //Interface Registration
        public IReleaseNote ReleaseNoteRepository { get; private set; }
        public ISystemAttribute SystemAttributeRepository { get; private set; }
        public ISystemAttributeValue SystemAttributeValueRepository { get; private set; }

        //Global Methods
        public void UpdateDatabase()
        {
            db.SaveChanges();
        }
    }
}
