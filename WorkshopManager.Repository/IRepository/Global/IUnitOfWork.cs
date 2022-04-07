using WorkshopManager.Repository.IRepository.CustomerRelationshipManagement;
using WorkshopManager.Repository.IRepository.System;

namespace WorkshopManager.Repository.IRepository.Global
{
    public interface IUnitOfWork
    {
        IControllerViewMapping ControllerViewMappingRepository { get; }
        ICustomer CustomerRepository { get; }
        IGender GenderRepository { get; }
        IReleaseNote ReleaseNoteRepository { get; }
        void UpdateDatabase();
    }
}
