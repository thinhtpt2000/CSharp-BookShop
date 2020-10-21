namespace BookStore.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}