using WorkshopManager.DataServices;
using WorkshopManager.Models.System.BaseModels;
using WorkshopManager.Repository.Implementation.Global;
using WorkshopManager.Repository.IRepository.System;

namespace WorkshopManager.Repository.Implementation.System
{
    public class ReleaseNoteRepository : Repository<ReleaseNote>, IReleaseNote
    {
        private readonly ApplicationDbContext db;

        public ReleaseNoteRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public ReleaseNote GetLatestReleaseNote()
        {
            return db.ReleaseNotes.OrderByDescending(x => x.ReleaseDate).FirstOrDefault();
        }

        public void UpdateRecord(ReleaseNote obj)
        {
            db.Update(obj);
        }
    }
}

