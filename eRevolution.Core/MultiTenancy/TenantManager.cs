using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using eRevolution.Authorization.Roles;
using eRevolution.Editions;
using eRevolution.Users;

namespace eRevolution.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, Role, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager
            )
        {
        }
    }
}