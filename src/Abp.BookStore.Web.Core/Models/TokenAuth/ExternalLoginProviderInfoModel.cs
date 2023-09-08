using Abp.AutoMapper;
using Abp.BookStore.Authentication.External;

namespace Abp.BookStore.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
