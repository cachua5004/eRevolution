using Abp.Application.Features;
using eRevolution.Authorization.Roles;
using eRevolution.MultiTenancy;
using eRevolution.Users;

namespace eRevolution.Features
{
    public class FeatureValueStore : AbpFeatureValueStore<Tenant, Role, User>
    {
        public FeatureValueStore(TenantManager tenantManager)
            : base(tenantManager)
        {
        }
    }
}