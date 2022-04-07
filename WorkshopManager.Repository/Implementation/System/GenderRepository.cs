using WorkshopManager.DataServices;
using WorkshopManager.Models.System.BaseModels;
using WorkshopManager.Repository.Implementation.Global;
using WorkshopManager.Repository.IRepository.System;

namespace WorkshopManager.Repository.Implementation.System
{
    public class GenderRepository : Repository<Gender>, IGender
    {
        private readonly ApplicationDbContext db;

        public GenderRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public void UpdateRecord(Gender obj)
        {
            db.Update(obj);
        }

    }
}

