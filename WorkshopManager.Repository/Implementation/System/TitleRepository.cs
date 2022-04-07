using Microsoft.AspNetCore.Mvc.Rendering;
using WorkshopManager.DataServices;
using WorkshopManager.Models.System.BaseModels;
using WorkshopManager.Repository.Implementation.Global;
using WorkshopManager.Repository.IRepository.System;

namespace WorkshopManager.Repository.Implementation.System
{
    public class TitleRepository : Repository<Title>, ITitle
    {
        private readonly ApplicationDbContext db;

        public TitleRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public SelectList GenerateDropDowns()
        {
            return new SelectList(db.Titles.OrderBy(x => x.Description), "Id", "Description");
        }

        public void UpdateRecord(Title obj)
        {
            db.Update(obj);
        }

    }
}

