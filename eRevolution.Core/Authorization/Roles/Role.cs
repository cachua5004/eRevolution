using Abp.Authorization.Roles;
using eRevolution.MultiTenancy;
using eRevolution.Users;

namespace eRevolution.Authorization.Roles
{
    public class Role : AbpRole<Tenant, User>
    {

    }
}