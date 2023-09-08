using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.BookStore.MultiTenancy;

namespace Abp.BookStore.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
