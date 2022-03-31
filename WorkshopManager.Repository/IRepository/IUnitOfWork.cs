namespace WorkshopManager.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ISystemAttribute SystemAttributeRepository { get; }
        IReleaseNote ReleaseNoteRepository { get; }

        void UpdateDatabase();
    }
}
