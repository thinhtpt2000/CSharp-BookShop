using System;

namespace BookStore.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        BookStoreDbContext Init();
    }
}