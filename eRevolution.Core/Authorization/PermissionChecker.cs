using Abp.Authorization;
using eRevolution.Authorization.Roles;
using eRevolution.MultiTenancy;
using eRevolution.Users;

namespace eRevolution.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
