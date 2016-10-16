using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using SimpleZero.EntityFramework;

namespace SimpleZero
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(SimpleZeroCoreModule))]
    public class SimpleZeroDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<SimpleZeroDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
