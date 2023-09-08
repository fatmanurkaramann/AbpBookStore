using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Abp.BookStore.Authorization.Roles;
using Abp.BookStore.Authorization.Users;
using Abp.BookStore.MultiTenancy;

namespace Abp.BookStore.EntityFrameworkCore
{
    public class BookStoreDbContext : AbpZeroDbContext<Tenant, Role, User, BookStoreDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
            : base(options)
        {
        }
    }
}
