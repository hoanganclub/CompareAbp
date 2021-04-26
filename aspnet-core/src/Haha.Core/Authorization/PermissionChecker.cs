using Abp.Authorization;
using Haha.Authorization.Roles;
using Haha.Authorization.Users;

namespace Haha.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
