using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using SimpleEmployeeManagement.EntityFramework;

namespace SimpleEmployeeManagement
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(SimpleEmployeeManagementCoreModule))]
    public class SimpleEmployeeManagementDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<SimpleEmployeeManagementDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
