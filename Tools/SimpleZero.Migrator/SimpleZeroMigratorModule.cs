using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using SimpleZero.EntityFramework;

namespace SimpleZero.Migrator
{
    [DependsOn(typeof(SimpleZeroDataModule))]
    public class SimpleZeroMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<SimpleZeroDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}