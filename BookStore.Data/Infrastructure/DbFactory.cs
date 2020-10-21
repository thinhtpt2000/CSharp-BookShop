namespace BookStore.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private BookStoreDbContext dbContext;

        public BookStoreDbContext Init()
        {
            return dbContext ?? (dbContext = new BookStoreDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}