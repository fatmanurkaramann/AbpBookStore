using Abp.AutoMapper;
using Abp.BookStore.Roles.Dto;
using Abp.BookStore.Web.Models.Common;

namespace Abp.BookStore.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
