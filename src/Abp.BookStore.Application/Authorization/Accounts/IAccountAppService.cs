using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.BookStore.Authorization.Accounts.Dto;

namespace Abp.BookStore.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
