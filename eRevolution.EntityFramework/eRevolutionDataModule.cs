using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using eRevolution.EntityFramework;

namespace eRevolution
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(eRevolutionCoreModule))]
    public class eRevolutionDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
