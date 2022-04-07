namespace WorkshopManager.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICustomer CustomerRepository { get; }
        IReleaseNote ReleaseNoteRepository { get; }
        void UpdateDatabase();
    }
}
