using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace SimpleZero
{
    [DependsOn(typeof(SimpleZeroCoreModule), typeof(AbpAutoMapperModule))]
    public class SimpleZeroApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
            {
                //Add your custom AutoMapper mappings here...
                //mapper.CreateMap<,>()
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
