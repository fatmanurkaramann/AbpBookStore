using Abp.Application.Services;
using Abp.BookStore.MultiTenancy.Dto;

namespace Abp.BookStore.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

