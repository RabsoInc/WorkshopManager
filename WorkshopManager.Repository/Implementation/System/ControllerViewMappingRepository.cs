using WorkshopManager.DataServices;
using WorkshopManager.Models.System.BaseModels;
using WorkshopManager.Repository.Implementation.Global;
using WorkshopManager.Repository.IRepository.System;

namespace WorkshopManager.Repository.Implementation.System
{
    public class ControllerViewMappingRepository : Repository<ControllerViewMapping>, IControllerViewMapping
    {
        private readonly ApplicationDbContext db;

        public ControllerViewMappingRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public void UpdateRecord(ControllerViewMapping obj)
        {
            db.Update(obj);
        }
    }
}

