using System.Collections.Generic;
using Abp.BookStore.Roles.Dto;

namespace Abp.BookStore.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}