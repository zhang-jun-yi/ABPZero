using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using MT.EntityFramework;

namespace MT.Migrator
{
    [DependsOn(typeof(MTDataModule))]
    public class MTMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<MTDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}