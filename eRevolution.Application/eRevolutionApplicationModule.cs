using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace eRevolution
{
    [DependsOn(typeof(eRevolutionCoreModule), typeof(AbpAutoMapperModule))]
    public class eRevolutionApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
