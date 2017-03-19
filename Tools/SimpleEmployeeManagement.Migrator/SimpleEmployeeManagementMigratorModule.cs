using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using SimpleEmployeeManagement.EntityFramework;

namespace SimpleEmployeeManagement.Migrator
{
    [DependsOn(typeof(SimpleEmployeeManagementDataModule))]
    public class SimpleEmployeeManagementMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<SimpleEmployeeManagementDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}