using System.Threading.Tasks;
using Abp.BookStore.Configuration.Dto;

namespace Abp.BookStore.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
