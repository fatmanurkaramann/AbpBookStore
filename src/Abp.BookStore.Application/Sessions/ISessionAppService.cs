using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.BookStore.Sessions.Dto;

namespace Abp.BookStore.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
