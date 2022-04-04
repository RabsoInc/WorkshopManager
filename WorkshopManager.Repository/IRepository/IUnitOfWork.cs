namespace WorkshopManager.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IReleaseNote ReleaseNoteRepository { get; }
        ISystemAttribute SystemAttributeRepository { get; }
        ISystemAttributeValue SystemAttributeValueRepository { get; }
        void UpdateDatabase();
    }
}
