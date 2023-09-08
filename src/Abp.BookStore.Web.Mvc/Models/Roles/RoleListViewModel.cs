using System.Collections.Generic;
using Abp.BookStore.Roles.Dto;

namespace Abp.BookStore.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
