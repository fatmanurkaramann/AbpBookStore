using System.Collections.Generic;
using Abp.BookStore.Roles.Dto;

namespace Abp.BookStore.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
