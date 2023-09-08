using Abp.Authorization;
using Abp.BookStore.Authorization.Roles;
using Abp.BookStore.Authorization.Users;

namespace Abp.BookStore.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
