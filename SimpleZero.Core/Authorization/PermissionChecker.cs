using Abp.Authorization;
using SimpleZero.Authorization.Roles;
using SimpleZero.MultiTenancy;
using SimpleZero.Users;

namespace SimpleZero.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
