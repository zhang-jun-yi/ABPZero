using Abp.Authorization;
using MT.Authorization.Roles;
using MT.Authorization.Users;

namespace MT.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
