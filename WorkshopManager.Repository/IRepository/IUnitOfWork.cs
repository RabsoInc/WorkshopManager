namespace WorkshopManager.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ISystemAttribute SystemAttributeRepository { get; }

        void UpdateDatabase();
    }
}
